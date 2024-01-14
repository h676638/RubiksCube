using System.Drawing;
using System;

public class CubeSide {
    EnumColors[][] side;
    public CubeSide() {
        side = new EnumColors[3][];
        for (int i = 0; i<side.Length; i++) {
            side[i] = new EnumColors[3];
        }
    }
    public void randomize() {
        Random random = new Random();
        foreach (EnumColors[] each in side) {
            for (int i = 0; i<each.Length; i++) {
                each[i] = (EnumColors)random.Next(Enum.GetValues(typeof(EnumColors)).Length);
            }
        }
    }
    public void rotateCW() {
        EnumColors[][] tempSide = new EnumColors[3][];
        for (int i = 0; i<tempSide.Length; i++) {
            tempSide[i] = new EnumColors[3];
        }
        for (int i = 0, j = 2; i < side.Length; i++, j--) {
            tempSide[i][2] = side[0][i];
            tempSide[2][j] = side[i][2];
            tempSide[j][0] = side[2][j];
            tempSide[0][i] = side[j][0];
        }
        side = tempSide;
    }
    public void rotateACW() {
        EnumColors[][] tempSide = new EnumColors[3][];
        for (int i = 0; i<tempSide.Length; i++) {
            tempSide[i] = new EnumColors[3];
        }
        for (int i = 0, j = 2; i < side.Length; i++, j--) {
            tempSide[i][2] = side[2][j];
            tempSide[2][j] = side[j][0];
            tempSide[j][0] = side[0][i];
            tempSide[0][i] = side[i][2];
        }
        side = tempSide;
    }
    /*public EnumColors twistGeneric(EnumColors inputColor, int first, int second, int third) {
        EnumColors temp = side[first];
        EnumColors temp2 = side[second];
        side[first] = inputColor;
        side[second] = temp;
        temp = side[third];
        side[third] = temp2;
        return temp;
    public EnumColors twistVerticalWest(EnumColors inputColor, bool reversed) {
        int first, second, third;
        if (!reversed) {
            first = 0;
            second = 3;
            third = 6;
        }
        else {
            first = 6;
            second = 3;
            third = 0;
        }
        return twistGeneric(inputColor, first, second, third);
    }
     public EnumColors twistVerticalEast(EnumColors inputColor, bool reversed) {
        int first, second, third;
        if (!reversed) {
            first = 2;
            second = 3;
            third = 4;
        }
        else {
            first = 4;
            second = 3;
            third = 2;
        }
        return twistGeneric(inputColor, first, second, third);
    }
     public EnumColors twistHorizontalNorth(EnumColors inputColor, bool reversed) {
        int first, second, third;
        if (!reversed) {
            first = 0;
            second = 1;
            third = 2;
        }
        else {
            first = 2;
            second = 1;
            third = 0;
        }
        return twistGeneric(inputColor, first, second, third);
    }
     public EnumColors twistHorizontalSouth(EnumColors inputColor, bool reversed) {
        int first, second, third;
        if (!reversed) {
            first = 6;
            second = 5;
            third = 4;
        }
        else {
            first = 4;
            second = 5;
            third = 6;
        }
        return twistGeneric(inputColor, first, second, third);
    }
    }*/
    public String PrintOut() {
        String result = "";
        foreach (EnumColors[] each in side) {
            foreach (EnumColors every in each) {
                result += every + " ";
            }
            result = result.Remove(result.Length-1);
            result += "\n";
        }
        return result;
        
    }
    public EnumColors[] GetTopRow() {
        return side[0];
    }
    public void SetTopRow(EnumColors[] row) {
        side[0] = row;
    }
    public EnumColors[] GetBotRow() {
        return side[2];
    }

     public void SetBotRow(EnumColors[] row) {
        side[2] = row;
    }
    public EnumColors[] GetLeftCol() {
        EnumColors[] result = new EnumColors[3];
        for (int i = 0; i < result.Length; i++) {
            result[i] = side[i][0];
        }
        return result;
    }
    
    public void SetLeftCol(EnumColors[] col) {
        for (int i = 0; i < col.Length; i++) {
            side[i][0] = col[i];
        }
    }
    public EnumColors[] GetRightCol() {
        EnumColors[] result = new EnumColors[3];
        for (int i = 0; i < result.Length; i++) {
            result[i] = side[i][2];
        }
        return result;
    }
    public void SetRightCol(EnumColors[] col) {
        for (int i = 0; i < col.Length; i++) {
            side[i][2] = col[i];
        }
    }
    
    public void SetSide(EnumColors[][] newSide) {
        side = newSide;
    }
    public EnumColors[] getColor(int index) {
        return side[index];
    }

}