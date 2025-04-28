public class NumericUpDownSinFlechas : NumericUpDown
{
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        Controls[0].Hide(); // Oculta el control interno que contiene las flechas
    }
}
