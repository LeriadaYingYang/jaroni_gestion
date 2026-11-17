namespace jaroni_gestion.Formularios;

partial class FormularioRedDistribucion
{
    private System.ComponentModel.IContainer components = null;
    private Label etiquetaTitulo;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        etiquetaTitulo = new Label();
        SuspendLayout();
        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Location = new Point(24, 24);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Text = "Red de Distribución";
        ClientSize = new Size(600, 450);
        Controls.Add(etiquetaTitulo);
        Name = "FormularioRedDistribucion";
        Text = "Red de Distribución";
        ResumeLayout(false);
        PerformLayout();
    }
}
