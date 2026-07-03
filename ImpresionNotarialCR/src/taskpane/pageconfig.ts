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
        leftIndent: 4.32,
        rightIndent: -4.32,
        topMargin: 127.44,
        bottomMargin: 141.84,
        leftMargin: 87.84,
        rightMargin: 59.76,
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