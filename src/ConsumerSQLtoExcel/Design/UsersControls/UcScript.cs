using ConsumerSQLtoExcel.Entities;
namespace ConsumerSQLtoExcel.Design.UsersControls
{
    public partial class UcScript : UserControl
    {
        private ScriptConfig ScriptConfig { get; set; }
        public bool IsActive = false;
        private FlowLayoutPanel FlowParent { get; set; }
        internal UcScript(ScriptConfig scriptConfig, FlowLayoutPanel flowParent)
        {
            InitializeComponent();
            ScriptConfig = scriptConfig;
            RandomColor();
            FlowParent = flowParent;
        }
        private void RandomColor()
        {
            List<Color> Cores =
            [
                Color.Lime,
                Color.SeaGreen,
                Color.DarkRed,
                Color.SteelBlue,
                Color.Yellow,
                Color.DeepPink,
                Color.OrangeRed
            ];

            Random rand = new();
            PnColor.BackColor = Cores[rand.Next(Cores.Count)];
        }
        private void LblScriptNameClick(object sender, EventArgs e)
        {
            SelectThis();
        }
        internal ScriptConfig GetScript()
        {
            return ScriptConfig;
        }
        internal void SelectThis()
        {
            foreach (UcScript uc in FlowParent.Controls)
            {
                uc.IsActive = false;
                uc.BorderStyle = BorderStyle.FixedSingle;
            }

            IsActive = true;
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
