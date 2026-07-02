export interface MargingLayout {
    leftIndent: number;
    rightIndent: number;
    topMargin: number;
    bottomMargin: number;
    leftMargin: number;
    rightMargin: number;
}

export const pageMarginsConfig: Record<string, MargingLayout> = {
    front: {
        leftIndent: 0.06,
        rightIndent: -0.06,
        topMargin: 1.77,
        bottomMargin: 1.97,
        leftMargin: 1.22,
        rightMargin: 0.83,
    },

    back: {
        leftIndent: 0.07,
        rightIndent: -0.07,
        topMargin: 1.77,
        bottomMargin: 1.97,
        leftMargin: 0.83,
        rightMargin: 1.22
    }
}