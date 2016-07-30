using UnityEngine;
using System.Collections;

public abstract class KeyboardInput : MonoBehaviour {

	//Interprets the input
	public void updateInput()
	{
		if (Input.GetKey("a")){
			aIsDown();
		}
		if (Input.GetKey("b"))
		{
			bIsDown();
		}
		if (Input.GetKey("c"))
		{
			cIsDown();
		}
		if (Input.GetKey("d"))
		{
			dIsDown();
		}
		if (Input.GetKey("e"))
		{
			eIsDown();
		}
		if (Input.GetKey("f"))
		{
			fIsDown();
		}
		if (Input.GetKey("g"))
		{
			gIsDown();
		}
		if (Input.GetKey("h"))
		{
			hIsDown();
		}
		if (Input.GetKey("i"))
		{
			iIsDown();
		}
		if (Input.GetKey("j"))
		{
			jIsDown();
		}
		if (Input.GetKey("k"))
		{
			kIsDown();
		}
		if (Input.GetKey("l"))
		{
			lIsDown();
		}
		if (Input.GetKey("m"))
		{
			mIsDown();
		}
		if (Input.GetKey("n"))
		{
			nIsDown();
		}
		if (Input.GetKey("o"))
		{
			oIsDown();
		}
		if (Input.GetKey("p"))
		{
			pIsDown();
		}
		if (Input.GetKey("q"))
		{
			qIsDown();
		}
		if (Input.GetKey("r"))
		{
			rIsDown();
		}
		if (Input.GetKey("s"))
		{
			sIsDown();
		}
		if (Input.GetKey("t"))
		{
			tIsDown();
		}
		if (Input.GetKey("u"))
		{
			uIsDown();
		}
		if (Input.GetKey("v"))
		{
			vIsDown();
		}
		if (Input.GetKey("w"))
		{
			wIsDown();
		}
		if (Input.GetKey("x"))
		{
			xIsDown();
		}
		if (Input.GetKey("y"))
		{
			yIsDown();
		}
		if (Input.GetKey("z"))
		{
			zIsDown();
		}
		if (Input.GetKey("1"))
		{
			oneIsDown();
		}
		if (Input.GetKey("2"))
		{
			twoIsDown();
		}
		if (Input.GetKey("3"))
		{
			threeIsDown();
		}
		if (Input.GetKey("4"))
		{
			fourIsDown();
		}
		if (Input.GetKey("5"))
		{
			fiveIsDown();
		}
		if (Input.GetKey("6"))
		{
			sixIsDown();
		}
		if (Input.GetKey("7"))
		{
			sevenIsDown();
		}
		if (Input.GetKey("8"))
		{
			eightIsDown();
		}
		if (Input.GetKey("9"))
		{
			nineIsDown();
		}
		if (Input.GetKey("0"))
		{
			zeroIsDown();
		}
		if (Input.GetKey("[1]"))
		{
			oneIsDown();
		}
		if (Input.GetKey("[2]"))
		{
			twoIsDown();
		}
		if (Input.GetKey("[3]"))
		{
			threeIsDown();
		}
		if (Input.GetKey("[4]"))
		{
			fourIsDown();
		}
		if (Input.GetKey("[5]"))
		{
			fiveIsDown();
		}
		if (Input.GetKey("[6]"))
		{
			sixIsDown();
		}
		if (Input.GetKey("[7]"))
		{
			sevenIsDown();
		}
		if (Input.GetKey("[8]"))
		{
			eightIsDown();
		}
		if (Input.GetKey("[9]"))
		{
			nineIsDown();
		}
		if (Input.GetKey("[0]"))
		{
			zeroIsDown();
		}
		if (Input.GetKey("left shift"))
		{
			lsIsDown();
		}
		if (Input.GetKey("left ctrl"))
		{
			lcIsDown();
		}
		if (Input.GetKey("left alt"))
		{
			laIsDown();
		}
		if (Input.GetKey("right shift"))
		{
			rsIsDown();
		}
		if (Input.GetKey("right ctrl"))
		{
			rcIsDown();
		}
		if (Input.GetKey("right alt"))
		{
			raIsDown();
		}
		if (Input.GetKey("mouse 1"))
		{
			lmIsDown();
		}
		if (Input.GetKey("mouse 2"))
		{
			rmIsDown();
		}
		if (Input.GetKey("mouse 3"))
		{
			mmIsDown();
		}
		if (Input.GetKey("backspace"))
		{
			backIsDown();
		}
		if (Input.GetKey("tab"))
		{
			tabIsDown();
		}
		if (Input.GetKey("enter"))
		{
			enterIsDown();
		}
		if (Input.GetKey("space"))
		{
			spaceIsDown();
		}
		if (Input.GetKey("f1"))
		{
			foneIsDown();
		}
		if (Input.GetKey("f2"))
		{
			ftwoIsDown();
		}
		if (Input.GetKey("f3"))
		{
			fthreeIsDown();
		}
		if (Input.GetKey("f4"))
		{
			ffourIsDown();
		}
		if (Input.GetKey("f5"))
		{
			ffiveIsDown();
		}
		if (Input.GetKey("f6"))
		{
			fsixIsDown();
		}
		if (Input.GetKey("f7"))
		{
			fsevenIsDown();
		}
		if (Input.GetKey("f8"))
		{
			feightIsDown();
		}
		if (Input.GetKey("f9"))
		{
			fnineIsDown();
		}
		if (Input.GetKey("f10"))
		{
			ftenIsDown();
		}
		if (Input.GetKey("f11"))
		{
			felevenIsDown();
		}
		if (Input.GetKey("f12"))
		{
			ftwelveIsDown();
		}

	}

	//All the different alphabet keys
	protected virtual void aIsDown() { }
	protected virtual void bIsDown() { }
	protected virtual void cIsDown() { }
	protected virtual void dIsDown() { }
	protected virtual void eIsDown() { }
	protected virtual void fIsDown() { }
	protected virtual void gIsDown() { }
	protected virtual void hIsDown() { }
	protected virtual void iIsDown() { }
	protected virtual void jIsDown() { }
	protected virtual void kIsDown() { }
	protected virtual void lIsDown() { }
	protected virtual void mIsDown() { }
	protected virtual void nIsDown() { }
	protected virtual void oIsDown() { }
	protected virtual void pIsDown() { }
	protected virtual void qIsDown() { }
	protected virtual void rIsDown() { }
	protected virtual void sIsDown() { }
	protected virtual void tIsDown() { }
	protected virtual void uIsDown() { }
	protected virtual void vIsDown() { }
	protected virtual void wIsDown() { }
	protected virtual void xIsDown() { }
	protected virtual void yIsDown() { }
	protected virtual void zIsDown() { }
	//All the different number keys
	protected virtual void oneIsDown() { }
	protected virtual void twoIsDown() { }
	protected virtual void threeIsDown() { }
	protected virtual void fourIsDown() { }
	protected virtual void fiveIsDown() { }
	protected virtual void sixIsDown() { }
	protected virtual void sevenIsDown() { }
	protected virtual void eightIsDown() { }
	protected virtual void nineIsDown() { }
	protected virtual void zeroIsDown() { }
	//Shift, control, and alternative
	protected virtual void lsIsDown() { }
	protected virtual void lcIsDown() { }
	protected virtual void laIsDown() { }
	protected virtual void rsIsDown() { }
	protected virtual void rcIsDown() { }
	protected virtual void raIsDown() { }
	//Mouse
	protected virtual void lmIsDown() { }
	protected virtual void rmIsDown() { }
	protected virtual void mmIsDown() { }
	//Back, tab, enter, and space
	protected virtual void backIsDown() { }
	protected virtual void tabIsDown() { }
	protected virtual void enterIsDown() { }
	protected virtual void spaceIsDown() { }
	//Function buttons
	protected virtual void foneIsDown() { }
	protected virtual void ftwoIsDown() { }
	protected virtual void fthreeIsDown() { }
	protected virtual void ffourIsDown() { }
	protected virtual void ffiveIsDown() { }
	protected virtual void fsixIsDown() { }
	protected virtual void fsevenIsDown() { }
	protected virtual void feightIsDown() { }
	protected virtual void fnineIsDown() { }
	protected virtual void ftenIsDown() { }
	protected virtual void felevenIsDown() { }
	protected virtual void ftwelveIsDown() { }

}
