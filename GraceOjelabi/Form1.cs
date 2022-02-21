namespace GraceOjelabi
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_stdSubmenu.Visible = false;
            panel_tchSubmenu.Visible = false;
            panel_courSubmenu.Visible = false;
            panel_gradSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_stdSubmenu.Visible == true)
                panel_stdSubmenu.Visible = false;
            if (panel_tchSubmenu.Visible == true)
                panel_tchSubmenu.Visible = false;
            if (panel_courSubmenu.Visible == true)
                panel_courSubmenu.Visible = false;
            if (panel_gradSubmenu.Visible == true)
                panel_gradSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        #region StudentSubCourse
        private void button_regStd_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdSubmenu);
        }

        private void button_manStd_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_emerStd_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_staStd_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_prtStd_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }
        #endregion StudentSubMenu
        private void button_tch_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_tchSubmenu);
        }
        #region TeacherSubMenu
        private void button_entTch_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_staTch_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_prtTch_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }
        #endregion TeacherSubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courSubmenu);
        }
        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_manCourse_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_prtCourse_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }
        #endregion CourseSubmenu
        private void button_grade_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_gradSubmenu);
        }
        #region GradeSubmenu
        private void button_newGrade_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_manGrade_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }

        private void button_prtGrade_Click(object sender, EventArgs e)
        {
            // ...
            // .. Your Code
            // ...
            hideSubmenu();
        }
        #endregion GradeSubmenu

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel_stdSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}