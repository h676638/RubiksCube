using System.Drawing;
using System;

public class Cube {
    CubeSide[] sides;
    public Cube() {
        sides = new CubeSide[6];
        for (int i = 0; i < sides.Length; i++) {
            sides[i] = new CubeSide();
            sides[i].randomize();
        }
    }
    public void randomize() {
        foreach(CubeSide each in sides) {
            each.randomize();
        }
    }

    public void TwistHorizontalNorth(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[0], sides[1], sides[2], sides[3]} 
            : new CubeSide[]{sides[3], sides[2], sides[1], sides[0]};
        EnumColors[] tempRow = sidesArray[3].GetTopRow();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetTopRow(sidesArray[j].GetTopRow());
            }
            else {
                sidesArray[i].SetTopRow(tempRow);
            }
        }
        
        if (!reversed) {
            sides[5].rotateACW();
        }
        else {
            sides[5].rotateCW();
        } 
    }
        public void TwistHorizontalSouth(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[0], sides[1], sides[2], sides[3]} 
            : new CubeSide[]{sides[3], sides[2], sides[1], sides[0]};
        EnumColors[] tempRow = sidesArray[3].GetBotRow();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetBotRow(sidesArray[j].GetBotRow());
            }
            else {
                sidesArray[i].SetBotRow(tempRow);
            }
        }
        
        if (!reversed) {
            sides[4].rotateACW();
        }
        else {
            sides[4].rotateCW();
        } 
    }
    public void TwistVerticalFrontWest(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[0], sides[5], sides[2], sides[4]} 
            : new CubeSide[]{sides[4], sides[2], sides[5], sides[0]};
        EnumColors[] tempRow = sidesArray[3].GetLeftCol();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetLeftCol(sidesArray[j].GetLeftCol());
            }
            else {
                sidesArray[i].SetLeftCol(tempRow);
            }
        }
        
        if (!reversed) {
            sides[1].rotateACW();
        }
        else {
            sides[1].rotateCW();
        } 
    }
    public void TwistVerticalFrontEast(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[0], sides[5], sides[2], sides[4]} 
            : new CubeSide[]{sides[4], sides[2], sides[5], sides[0]};
        EnumColors[] tempRow = sidesArray[3].GetRightCol();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetRightCol(sidesArray[j].GetRightCol());
            }
            else {
                sidesArray[i].SetRightCol(tempRow);
            }
        }
        
        if (!reversed) {
            sides[3].rotateACW();
        }
        else {
            sides[3].rotateCW();
        } 
    }
    public void TwistVerticalSideWest(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[1], sides[5], sides[3], sides[4]} 
            : new CubeSide[]{sides[4], sides[3], sides[5], sides[1]};
        EnumColors[] tempRow = sidesArray[3].GetLeftCol();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetLeftCol(sidesArray[j].GetLeftCol());
            }
            else {
                sidesArray[i].SetLeftCol(tempRow);
            }
        }
        
        if (!reversed) {
            sides[0].rotateACW();
        }
        else {
            sides[0].rotateCW();
        } 
    }
    public void TwistVerticalSideEast(bool reversed) {
        CubeSide[] sidesArray = !reversed 
            ? new CubeSide[] {sides[1], sides[5], sides[3], sides[4]} 
            : new CubeSide[]{sides[4], sides[3], sides[5], sides[1]};
        EnumColors[] tempRow = sidesArray[3].GetRightCol();
        for (int i = 3, j = 2; i >= 0; i--, j--) {
            Console.WriteLine(this.PrintOut());
            if (i != 0) {
                sidesArray[i].SetRightCol(sidesArray[j].GetRightCol());
            }
            else {
                sidesArray[i].SetRightCol(tempRow);
            }
        }
        
        if (!reversed) {
            sides[2].rotateACW();
        }
        else {
            sides[2].rotateCW();
        } 
    }
    
    public String PrintOut() {
        String a = "";
        foreach (CubeSide each in sides) {
            a += "\n" + each.PrintOut();
        }
        return a;
    }
}