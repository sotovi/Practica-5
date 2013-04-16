using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnDivClicked (object sender, EventArgs e)
	{
		int Num1 = int.Parse (this.Numero1.Text);
		int Num2 = int.Parse (this.Numero2.Text);
		int Resul = Num1/Num2;
			this.Resultado.Text=Resul.ToString ();
	}

	protected void OnBtnMulClicked (object sender, EventArgs e)
	{
		int Num1 = int.Parse (this.Numero1.Text);
		int Num2 = int.Parse (this.Numero2.Text);
		int Resul= Num1*Num2;
			this.Resultado.Text=Resul.ToString();
	}

	protected void OnBtnResClicked (object sender, EventArgs e)
	{
		int Num1 = int.Parse (this.Numero1.Text);
		int Num2 = int.Parse (this.Numero2.Text);
		int Resul= Num1-Num2;
		this.Resultado.Text=Resul.ToString();
	}

	protected void OnBtnRes1Clicked (object sender, EventArgs e)
	{
		int Num1 = int.Parse (this.Numero1.Text);
		int Num2 = int.Parse (this.Numero2.Text);
		int Resul= Num1+Num2;
		this.Resultado.Text=Resul.ToString();
	}
}
