namespace ConsumerSQLtoExcel.Controllers
{
    public class InterfaceController
    {
        public static void PersonalizarComboBox(ComboBox comboBox, string textoDecorativo)
        {
            // Aplicar estilo moderno na ComboBox
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 10);
            comboBox.ForeColor = Color.DarkGray;
            comboBox.BackColor = Color.White;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Adicionar evento de pintura para o texto decorativo
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DrawItem += (sender, e) => ComboBox_DrawItem(sender, e, textoDecorativo);
        }

        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e, string textoDecorativo)
        {
            ComboBox comboBox = sender as ComboBox;

            // Desenhar o fundo do item
            e.DrawBackground();

            // Verificar se o item atual é o selecionado
            bool isItemSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Definir a cor do texto
            Color textoColor = isItemSelected ? SystemColors.HighlightText : SystemColors.WindowText;

            // Definir a fonte
            Font fonte = new Font("Segoe UI", 10, FontStyle.Regular);

            // Desenhar o texto do item
            if (e.Index >= 0)
            {
                string itemTexto = comboBox.Items[e.Index].ToString();
                e.Graphics.DrawString(itemTexto, fonte, new SolidBrush(textoColor), e.Bounds);
            }
            else if (comboBox.Text == string.Empty)
            {
                // Desenhar o texto decorativo quando não há item selecionado
                e.Graphics.DrawString(textoDecorativo, fonte, new SolidBrush(Color.LightGray), e.Bounds);
            }

            e.DrawFocusRectangle();
        }
    }
}
