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
        leftIndent: 0,
        rightIndent: 0,
        topMargin: 127.44,
        bottomMargin: 137.00,
        leftMargin: 87.84,
        rightMargin: 59.76,
    },

    back: {
        leftIndent: 0,
        rightIndent: 0,
        topMargin: 127.44,
        bottomMargin: 137.00,
        leftMargin: 59.43,
        rightMargin: 87.84
    }
}