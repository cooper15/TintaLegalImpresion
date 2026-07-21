/*
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

import { MargingLayout, pageMarginsConfig } from "./pageconfig";

/* global document, Office, Word */

Office.onReady((info) => {
  if (info.host === Office.HostType.Word) {
    document.getElementById("app-body")!.style.display = "flex";
    optionSelected();
    showLineNumber();
  }
});

export async function optionSelected() {
  const pageSelect = document.getElementById("pagina") as HTMLSelectElement;
  pageSelect.addEventListener("change", () => {
    const selectedValue = pageSelect.value;
    selectPageView(selectedValue);
  });
}

async function showLineNumber() {
  const lineNumber = document.getElementById("line-number") as HTMLInputElement;
  lineNumber.addEventListener("change", (e) => {
    (lineNumber.checked) ? turnOnLineNumbering(true) : turnOnLineNumbering(false);
  });
}

function selectPageView(selectedValue: string): any {
  return Word.run(async (context) => {
    document.getElementById("pagina-seleccione")?.remove();
    if (selectedValue === "Frente") {
      const document = context.document;
      pageConfiguration(document, pageMarginsConfig.front);
      generalParagraphConfiguration(document);
    } else if (selectedValue === "Vuelto") {
      const document = context.document;
      pageConfiguration(document, pageMarginsConfig.back);
      generalParagraphConfiguration(document); 
    }
     await context.sync();
  });
}

function pageConfiguration(document: Word.Document, page: MargingLayout) {
  document.pageSetup.paperSize = Word.PaperSize.legal;
  document.pageSetup.leftMargin = page.leftMargin;
  document.pageSetup.rightMargin = page.rightMargin;
  document.pageSetup.topMargin = page.topMargin;
  document.pageSetup.bottomMargin = page.bottomMargin;
  document.pageSetup.mirrorMargins = true;
  document.paragraphs.getFirst().leftIndent = page.leftIndent;
  document.paragraphs.getFirst().rightIndent = page.rightIndent;
}

function generalParagraphConfiguration(document: Word.Document) {
  document.paragraphs.getFirst().spaceBefore = 0;
  document.paragraphs.getFirst().spaceAfter = 0;
  document.paragraphs.getFirst().lineSpacing = 24;
  document.paragraphs.getFirst().alignment = Word.Alignment.justified;
  document.paragraphs.getFirst().font.name = "Calibri";
  document.paragraphs.getFirst().font.size = 10;
}

function turnOnLineNumbering(state: boolean) {
  console.log("state" + state);
  return Word.run(async (context) => {
    context.document.pageSetup.lineNumbering.isActive = state;
    await context.sync();
  });
}

