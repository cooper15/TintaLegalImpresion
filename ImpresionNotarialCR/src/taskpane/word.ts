/*
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

import { pageMarginsConfig } from "./pageconfig";

/* global document, Office, Word */

Office.onReady((info) => {
  if (info.host === Office.HostType.Word) {
    document.getElementById("sideload-msg").style.display = "none";
    document.getElementById("app-body").style.display = "flex";
    optionSelected();
    document.getElementById("run").onclick = runWord;
  }
});

export async function optionSelected() {
  const pageSelect = document.getElementById("pagina") as HTMLSelectElement;

  pageSelect.addEventListener("change", () => {
    const selectedValue = pageSelect.value;
    if (selectedValue === "Frente") {
      //FIXME we have to remove this duplicated code
      return Word.run(async (context) => {
        // insert a paragraph at the end of the document.
        const document = context.document;

        document.pageSetup.paperSize = Word.PaperSize.legal;
        document.pageSetup.leftMargin = pageMarginsConfig.front.leftMargin;
        document.pageSetup.rightMargin = pageMarginsConfig.front.rightMargin;
        document.pageSetup.topMargin = pageMarginsConfig.front.topMargin;
        document.pageSetup.bottomMargin = pageMarginsConfig.front.bottomMargin;

        document.paragraphs.getFirst().leftIndent = pageMarginsConfig.front.leftIndent;
        document.paragraphs.getFirst().rightIndent = pageMarginsConfig.front.rightIndent;

        document.paragraphs.getFirst().spaceBefore = 0;
        document.paragraphs.getFirst().spaceAfter = 0;
        document.paragraphs.getFirst().lineSpacing = 24.3;
        document.paragraphs.getFirst().alignment = Word.Alignment.justified;

        document.paragraphs.getFirst().font.name = "Calibri";
        document.paragraphs.getFirst().font.size = 10;

        await context.sync();
      });
    } else if (selectedValue === "Vuelto") {
      return Word.run(async (context) => {
        // insert a paragraph at the end of the document.
        const paragraph = context.document.body.insertParagraph(
          "Seleccionaste pagina vuelto",
          Word.InsertLocation.end
        );

        // change the paragraph color to blue.
        paragraph.font.color = "blue";

        await context.sync();
      });
    }
  });
}

export async function runWord() {
  return Word.run(async (context) => {
    /**
     * Insert your Word code here
     */

    // insert a paragraph at the end of the document.
    const paragraph = context.document.body.insertParagraph("Hello World", Word.InsertLocation.end);

    // change the paragraph color to blue.
    paragraph.font.color = "blue";

    await context.sync();
  });
}
