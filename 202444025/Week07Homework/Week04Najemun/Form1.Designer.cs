namespace Week04Najemun
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.lblBirtnYear = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirtnMonth = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblBirtnDay = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxContect = new System.Windows.Forms.TextBox();
            this.lblContect = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgDepartment = new System.Windows.Forms.TabPage();
            this.btnRemoveDepertment = new System.Windows.Forms.Button();
            this.btnRegisterDepartment = new System.Windows.Forms.Button();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDepartmentCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.tpgProfesson = new System.Windows.Forms.TabPage();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnRegisterProfessor = new System.Windows.Forms.Button();
            this.lbxProfessor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxProfessorNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxProfessorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProfessorDepartment = new System.Windows.Forms.ComboBox();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.cmbAdvisor = new System.Windows.Forms.ComboBox();
            this.tpgTestScore = new System.Windows.Forms.TabPage();
            this.btnTestRegScore = new System.Windows.Forms.Button();
            this.btnTestSearchStudent = new System.Windows.Forms.Button();
            this.lblTestCourse9Title = new System.Windows.Forms.Label();
            this.lblTestCourse6Title = new System.Windows.Forms.Label();
            this.lblTestCourse3Title = new System.Windows.Forms.Label();
            this.lblTestCourse8Title = new System.Windows.Forms.Label();
            this.lblTestCourse5Title = new System.Windows.Forms.Label();
            this.lblTestCourse2Title = new System.Windows.Forms.Label();
            this.lblTestCourse7Title = new System.Windows.Forms.Label();
            this.lblTestCourse4Title = new System.Windows.Forms.Label();
            this.lblTestCourse1Title = new System.Windows.Forms.Label();
            this.tbxTestScore9 = new System.Windows.Forms.TextBox();
            this.tbxTestScore6 = new System.Windows.Forms.TextBox();
            this.lblTestNumberTitle = new System.Windows.Forms.Label();
            this.tbxTestScore8 = new System.Windows.Forms.TextBox();
            this.tbxTestScore5 = new System.Windows.Forms.TextBox();
            this.tbxTestScore3 = new System.Windows.Forms.TextBox();
            this.tbxTestScore7 = new System.Windows.Forms.TextBox();
            this.tbxTestScore4 = new System.Windows.Forms.TextBox();
            this.tbxTestScore2 = new System.Windows.Forms.TextBox();
            this.tbxTestScore1 = new System.Windows.Forms.TextBox();
            this.tbxTestNumber = new System.Windows.Forms.TextBox();
            this.lblTestAverage = new System.Windows.Forms.Label();
            this.lblTestAverageTitle = new System.Windows.Forms.Label();
            this.lblTestTotalCount = new System.Windows.Forms.Label();
            this.lblTestTotalCountTitle = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblTestNameTitle = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpgDepartment.SuspendLayout();
            this.tpgProfesson.SuspendLayout();
            this.tpgStudent.SuspendLayout();
            this.tpgTestScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(6, 12);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 37);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "학번";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(75, 20);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(104, 21);
            this.tbxNumber.TabIndex = 1;
            this.tbxNumber.Text = "20";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(225, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 37);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(289, 20);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(104, 21);
            this.tbxName.TabIndex = 3;
            // 
            // lblBirth
            // 
            this.lblBirth.Location = new System.Drawing.Point(6, 49);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(63, 37);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "생년월일";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(75, 58);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(104, 21);
            this.tbxBirthYear.TabIndex = 5;
            this.tbxBirthYear.Text = "20";
            // 
            // lblBirtnYear
            // 
            this.lblBirtnYear.Location = new System.Drawing.Point(187, 56);
            this.lblBirtnYear.Name = "lblBirtnYear";
            this.lblBirtnYear.Size = new System.Drawing.Size(21, 27);
            this.lblBirtnYear.TabIndex = 6;
            this.lblBirtnYear.Text = "년";
            this.lblBirtnYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(229, 58);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(39, 21);
            this.tbxBirthMonth.TabIndex = 7;
            // 
            // lblBirtnMonth
            // 
            this.lblBirtnMonth.Location = new System.Drawing.Point(273, 56);
            this.lblBirtnMonth.Name = "lblBirtnMonth";
            this.lblBirtnMonth.Size = new System.Drawing.Size(26, 27);
            this.lblBirtnMonth.TabIndex = 8;
            this.lblBirtnMonth.Text = "월";
            this.lblBirtnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(310, 58);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(39, 21);
            this.tbxBirthDay.TabIndex = 9;
            // 
            // lblBirtnDay
            // 
            this.lblBirtnDay.Location = new System.Drawing.Point(355, 56);
            this.lblBirtnDay.Name = "lblBirtnDay";
            this.lblBirtnDay.Size = new System.Drawing.Size(26, 27);
            this.lblBirtnDay.TabIndex = 10;
            this.lblBirtnDay.Text = "일";
            this.lblBirtnDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(6, 86);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(63, 37);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "소속학과";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Location = new System.Drawing.Point(75, 95);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(318, 20);
            this.cmbDepartment.TabIndex = 12;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.Location = new System.Drawing.Point(6, 123);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(63, 37);
            this.lblAdvisor.TabIndex = 13;
            this.lblAdvisor.Text = "지도교수";
            this.lblAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(6, 160);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(63, 37);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "학년";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(227, 161);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 37);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "분반";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(75, 169);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(130, 20);
            this.cmbYear.TabIndex = 17;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(275, 169);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(118, 20);
            this.cmbClass.TabIndex = 18;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.Location = new System.Drawing.Point(6, 197);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(63, 37);
            this.lblRegStatus.TabIndex = 19;
            this.lblRegStatus.Text = "재적상태";
            this.lblRegStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(75, 206);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(130, 20);
            this.cmbRegStatus.TabIndex = 20;
            // 
            // lblAdress
            // 
            this.lblAdress.Location = new System.Drawing.Point(6, 234);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 37);
            this.lblAdress.TabIndex = 21;
            this.lblAdress.Text = "주소";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(75, 243);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(318, 21);
            this.tbxAdress.TabIndex = 22;
            // 
            // tbxContect
            // 
            this.tbxContect.Location = new System.Drawing.Point(75, 279);
            this.tbxContect.Name = "tbxContect";
            this.tbxContect.Size = new System.Drawing.Size(318, 21);
            this.tbxContect.TabIndex = 23;
            // 
            // lblContect
            // 
            this.lblContect.Location = new System.Drawing.Point(6, 270);
            this.lblContect.Name = "lblContect";
            this.lblContect.Size = new System.Drawing.Size(63, 37);
            this.lblContect.TabIndex = 24;
            this.lblContect.Text = "연락처";
            this.lblContect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Location = new System.Drawing.Point(8, 310);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(61, 54);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(75, 310);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(318, 54);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 12;
            this.lbxArray.Location = new System.Drawing.Point(409, 20);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(182, 100);
            this.lbxArray.TabIndex = 27;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 12;
            this.lbxList.Location = new System.Drawing.Point(409, 142);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(182, 100);
            this.lbxList.TabIndex = 28;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 12;
            this.lbxDictionary.Location = new System.Drawing.Point(409, 264);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(182, 100);
            this.lbxDictionary.TabIndex = 29;
            this.lbxDictionary.SelectedIndexChanged += new System.EventHandler(this.lbxDictionary_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgDepartment);
            this.tabMain.Controls.Add(this.tpgProfesson);
            this.tabMain.Controls.Add(this.tpgStudent);
            this.tabMain.Controls.Add(this.tpgTestScore);
            this.tabMain.ItemSize = new System.Drawing.Size(64, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(615, 422);
            this.tabMain.TabIndex = 30;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpgDepartment
            // 
            this.tpgDepartment.Controls.Add(this.btnRemoveDepertment);
            this.tpgDepartment.Controls.Add(this.btnRegisterDepartment);
            this.tpgDepartment.Controls.Add(this.lbxDepartment);
            this.tpgDepartment.Controls.Add(this.label1);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentCode);
            this.tpgDepartment.Controls.Add(this.label2);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentName);
            this.tpgDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpgDepartment.Name = "tpgDepartment";
            this.tpgDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDepartment.Size = new System.Drawing.Size(607, 384);
            this.tpgDepartment.TabIndex = 0;
            this.tpgDepartment.Text = "학과정보";
            this.tpgDepartment.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDepertment
            // 
            this.btnRemoveDepertment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveDepertment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveDepertment.Location = new System.Drawing.Point(492, 319);
            this.btnRemoveDepertment.Name = "btnRemoveDepertment";
            this.btnRemoveDepertment.Size = new System.Drawing.Size(93, 47);
            this.btnRemoveDepertment.TabIndex = 31;
            this.btnRemoveDepertment.Text = "삭제";
            this.btnRemoveDepertment.UseVisualStyleBackColor = false;
            this.btnRemoveDepertment.Click += new System.EventHandler(this.btnRemoveDepertment_Click);
            // 
            // btnRegisterDepartment
            // 
            this.btnRegisterDepartment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegisterDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegisterDepartment.Location = new System.Drawing.Point(190, 27);
            this.btnRegisterDepartment.Name = "btnRegisterDepartment";
            this.btnRegisterDepartment.Size = new System.Drawing.Size(93, 44);
            this.btnRegisterDepartment.TabIndex = 30;
            this.btnRegisterDepartment.Text = "등록";
            this.btnRegisterDepartment.UseVisualStyleBackColor = false;
            this.btnRegisterDepartment.Click += new System.EventHandler(this.btnRegisterDepartment_Click);
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 12;
            this.lbxDepartment.Location = new System.Drawing.Point(13, 103);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(572, 196);
            this.lbxDepartment.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "학과코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDepartmentCode
            // 
            this.tbxDepartmentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentCode.Location = new System.Drawing.Point(80, 21);
            this.tbxDepartmentCode.Name = "tbxDepartmentCode";
            this.tbxDepartmentCode.Size = new System.Drawing.Size(104, 21);
            this.tbxDepartmentCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "학과이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentName.Location = new System.Drawing.Point(80, 58);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(104, 21);
            this.tbxDepartmentName.TabIndex = 7;
            // 
            // tpgProfesson
            // 
            this.tpgProfesson.Controls.Add(this.btnRemoveProfessor);
            this.tpgProfesson.Controls.Add(this.btnRegisterProfessor);
            this.tpgProfesson.Controls.Add(this.lbxProfessor);
            this.tpgProfesson.Controls.Add(this.label4);
            this.tpgProfesson.Controls.Add(this.tbxProfessorNumber);
            this.tpgProfesson.Controls.Add(this.label5);
            this.tpgProfesson.Controls.Add(this.tbxProfessorName);
            this.tpgProfesson.Controls.Add(this.label3);
            this.tpgProfesson.Controls.Add(this.cmbProfessorDepartment);
            this.tpgProfesson.Location = new System.Drawing.Point(4, 34);
            this.tpgProfesson.Name = "tpgProfesson";
            this.tpgProfesson.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProfesson.Size = new System.Drawing.Size(607, 384);
            this.tpgProfesson.TabIndex = 1;
            this.tpgProfesson.Text = "교수정보";
            this.tpgProfesson.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveProfessor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveProfessor.Location = new System.Drawing.Point(492, 318);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(93, 43);
            this.btnRemoveProfessor.TabIndex = 38;
            this.btnRemoveProfessor.Text = "삭제";
            this.btnRemoveProfessor.UseVisualStyleBackColor = false;
            this.btnRemoveProfessor.Click += new System.EventHandler(this.btnRemoveProfessor_Click);
            // 
            // btnRegisterProfessor
            // 
            this.btnRegisterProfessor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegisterProfessor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegisterProfessor.Location = new System.Drawing.Point(197, 56);
            this.btnRegisterProfessor.Name = "btnRegisterProfessor";
            this.btnRegisterProfessor.Size = new System.Drawing.Size(93, 45);
            this.btnRegisterProfessor.TabIndex = 37;
            this.btnRegisterProfessor.Text = "등록";
            this.btnRegisterProfessor.UseVisualStyleBackColor = false;
            this.btnRegisterProfessor.Click += new System.EventHandler(this.btnRegisterProfessor_Click);
            // 
            // lbxProfessor
            // 
            this.lbxProfessor.FormattingEnabled = true;
            this.lbxProfessor.ItemHeight = 12;
            this.lbxProfessor.Location = new System.Drawing.Point(13, 133);
            this.lbxProfessor.Name = "lbxProfessor";
            this.lbxProfessor.Size = new System.Drawing.Size(572, 172);
            this.lbxProfessor.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 37);
            this.label4.TabIndex = 32;
            this.label4.Text = "교수번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxProfessorNumber
            // 
            this.tbxProfessorNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorNumber.Location = new System.Drawing.Point(80, 51);
            this.tbxProfessorNumber.Name = "tbxProfessorNumber";
            this.tbxProfessorNumber.Size = new System.Drawing.Size(104, 21);
            this.tbxProfessorNumber.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 37);
            this.label5.TabIndex = 34;
            this.label5.Text = "교수이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxProfessorName
            // 
            this.tbxProfessorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorName.Location = new System.Drawing.Point(80, 88);
            this.tbxProfessorName.Name = "tbxProfessorName";
            this.tbxProfessorName.Size = new System.Drawing.Size(104, 21);
            this.tbxProfessorName.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "소속학과";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProfessorDepartment
            // 
            this.cmbProfessorDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessorDepartment.FormattingEnabled = true;
            this.cmbProfessorDepartment.Location = new System.Drawing.Point(80, 18);
            this.cmbProfessorDepartment.Name = "cmbProfessorDepartment";
            this.cmbProfessorDepartment.Size = new System.Drawing.Size(318, 20);
            this.cmbProfessorDepartment.TabIndex = 14;
            this.cmbProfessorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbProfessorDepartment_SelectedIndexChanged);
            // 
            // tpgStudent
            // 
            this.tpgStudent.Controls.Add(this.cmbAdvisor);
            this.tpgStudent.Controls.Add(this.lblNumber);
            this.tpgStudent.Controls.Add(this.lbxDictionary);
            this.tpgStudent.Controls.Add(this.tbxNumber);
            this.tpgStudent.Controls.Add(this.lbxList);
            this.tpgStudent.Controls.Add(this.lblName);
            this.tpgStudent.Controls.Add(this.lbxArray);
            this.tpgStudent.Controls.Add(this.tbxName);
            this.tpgStudent.Controls.Add(this.btnRegister);
            this.tpgStudent.Controls.Add(this.lblBirth);
            this.tpgStudent.Controls.Add(this.btnNew);
            this.tpgStudent.Controls.Add(this.tbxBirthYear);
            this.tpgStudent.Controls.Add(this.lblContect);
            this.tpgStudent.Controls.Add(this.lblBirtnYear);
            this.tpgStudent.Controls.Add(this.tbxContect);
            this.tpgStudent.Controls.Add(this.tbxBirthMonth);
            this.tpgStudent.Controls.Add(this.tbxAdress);
            this.tpgStudent.Controls.Add(this.lblBirtnMonth);
            this.tpgStudent.Controls.Add(this.lblAdress);
            this.tpgStudent.Controls.Add(this.tbxBirthDay);
            this.tpgStudent.Controls.Add(this.cmbRegStatus);
            this.tpgStudent.Controls.Add(this.lblBirtnDay);
            this.tpgStudent.Controls.Add(this.lblRegStatus);
            this.tpgStudent.Controls.Add(this.lblDepartment);
            this.tpgStudent.Controls.Add(this.cmbClass);
            this.tpgStudent.Controls.Add(this.cmbDepartment);
            this.tpgStudent.Controls.Add(this.cmbYear);
            this.tpgStudent.Controls.Add(this.lblAdvisor);
            this.tpgStudent.Controls.Add(this.lblClass);
            this.tpgStudent.Controls.Add(this.lblYear);
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStudent.Size = new System.Drawing.Size(607, 384);
            this.tpgStudent.TabIndex = 2;
            this.tpgStudent.Text = "학생정보";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // cmbAdvisor
            // 
            this.cmbAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvisor.FormattingEnabled = true;
            this.cmbAdvisor.Location = new System.Drawing.Point(75, 132);
            this.cmbAdvisor.Name = "cmbAdvisor";
            this.cmbAdvisor.Size = new System.Drawing.Size(318, 20);
            this.cmbAdvisor.TabIndex = 30;
            // 
            // tpgTestScore
            // 
            this.tpgTestScore.Controls.Add(this.btnTestRegScore);
            this.tpgTestScore.Controls.Add(this.btnTestSearchStudent);
            this.tpgTestScore.Controls.Add(this.lblTestCourse9Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse6Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse3Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse8Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse5Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse2Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse7Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse4Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse1Title);
            this.tpgTestScore.Controls.Add(this.tbxTestScore9);
            this.tpgTestScore.Controls.Add(this.tbxTestScore6);
            this.tpgTestScore.Controls.Add(this.lblTestNumberTitle);
            this.tpgTestScore.Controls.Add(this.tbxTestScore8);
            this.tpgTestScore.Controls.Add(this.tbxTestScore5);
            this.tpgTestScore.Controls.Add(this.tbxTestScore3);
            this.tpgTestScore.Controls.Add(this.tbxTestScore7);
            this.tpgTestScore.Controls.Add(this.tbxTestScore4);
            this.tpgTestScore.Controls.Add(this.tbxTestScore2);
            this.tpgTestScore.Controls.Add(this.tbxTestScore1);
            this.tpgTestScore.Controls.Add(this.tbxTestNumber);
            this.tpgTestScore.Controls.Add(this.lblTestAverage);
            this.tpgTestScore.Controls.Add(this.lblTestAverageTitle);
            this.tpgTestScore.Controls.Add(this.lblTestTotalCount);
            this.tpgTestScore.Controls.Add(this.lblTestTotalCountTitle);
            this.tpgTestScore.Controls.Add(this.lblTestName);
            this.tpgTestScore.Controls.Add(this.lblTestNameTitle);
            this.tpgTestScore.Location = new System.Drawing.Point(4, 34);
            this.tpgTestScore.Name = "tpgTestScore";
            this.tpgTestScore.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTestScore.Size = new System.Drawing.Size(607, 384);
            this.tpgTestScore.TabIndex = 3;
            this.tpgTestScore.Text = "성적처리(TEST)";
            this.tpgTestScore.UseVisualStyleBackColor = true;
            // 
            // btnTestRegScore
            // 
            this.btnTestRegScore.Location = new System.Drawing.Point(267, 292);
            this.btnTestRegScore.Name = "btnTestRegScore";
            this.btnTestRegScore.Size = new System.Drawing.Size(66, 48);
            this.btnTestRegScore.TabIndex = 41;
            this.btnTestRegScore.Text = "수정 및 완료";
            this.btnTestRegScore.UseVisualStyleBackColor = true;
            // 
            // btnTestSearchStudent
            // 
            this.btnTestSearchStudent.Location = new System.Drawing.Point(267, 34);
            this.btnTestSearchStudent.Name = "btnTestSearchStudent";
            this.btnTestSearchStudent.Size = new System.Drawing.Size(66, 48);
            this.btnTestSearchStudent.TabIndex = 40;
            this.btnTestSearchStudent.Text = "검색";
            this.btnTestSearchStudent.UseVisualStyleBackColor = true;
            this.btnTestSearchStudent.Click += new System.EventHandler(this.btnTestSearchStudent_Click);
            // 
            // lblTestCourse9Title
            // 
            this.lblTestCourse9Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse9Title.Location = new System.Drawing.Point(21, 319);
            this.lblTestCourse9Title.Name = "lblTestCourse9Title";
            this.lblTestCourse9Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse9Title.TabIndex = 15;
            this.lblTestCourse9Title.Text = "과목 9";
            this.lblTestCourse9Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse6Title
            // 
            this.lblTestCourse6Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse6Title.Location = new System.Drawing.Point(21, 238);
            this.lblTestCourse6Title.Name = "lblTestCourse6Title";
            this.lblTestCourse6Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse6Title.TabIndex = 16;
            this.lblTestCourse6Title.Text = "과목 6";
            this.lblTestCourse6Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse3Title
            // 
            this.lblTestCourse3Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse3Title.Location = new System.Drawing.Point(21, 155);
            this.lblTestCourse3Title.Name = "lblTestCourse3Title";
            this.lblTestCourse3Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse3Title.TabIndex = 17;
            this.lblTestCourse3Title.Text = "과목 3";
            this.lblTestCourse3Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse8Title
            // 
            this.lblTestCourse8Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse8Title.Location = new System.Drawing.Point(21, 292);
            this.lblTestCourse8Title.Name = "lblTestCourse8Title";
            this.lblTestCourse8Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse8Title.TabIndex = 18;
            this.lblTestCourse8Title.Text = "과목 8";
            this.lblTestCourse8Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse5Title
            // 
            this.lblTestCourse5Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse5Title.Location = new System.Drawing.Point(21, 211);
            this.lblTestCourse5Title.Name = "lblTestCourse5Title";
            this.lblTestCourse5Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse5Title.TabIndex = 19;
            this.lblTestCourse5Title.Text = "과목 5";
            this.lblTestCourse5Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse2Title
            // 
            this.lblTestCourse2Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse2Title.Location = new System.Drawing.Point(21, 128);
            this.lblTestCourse2Title.Name = "lblTestCourse2Title";
            this.lblTestCourse2Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse2Title.TabIndex = 20;
            this.lblTestCourse2Title.Text = "과목 2";
            this.lblTestCourse2Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse7Title
            // 
            this.lblTestCourse7Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse7Title.Location = new System.Drawing.Point(21, 265);
            this.lblTestCourse7Title.Name = "lblTestCourse7Title";
            this.lblTestCourse7Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse7Title.TabIndex = 21;
            this.lblTestCourse7Title.Text = "과목 7";
            this.lblTestCourse7Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse4Title
            // 
            this.lblTestCourse4Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse4Title.Location = new System.Drawing.Point(21, 184);
            this.lblTestCourse4Title.Name = "lblTestCourse4Title";
            this.lblTestCourse4Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse4Title.TabIndex = 22;
            this.lblTestCourse4Title.Text = "과목 4";
            this.lblTestCourse4Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse1Title
            // 
            this.lblTestCourse1Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse1Title.Location = new System.Drawing.Point(21, 101);
            this.lblTestCourse1Title.Name = "lblTestCourse1Title";
            this.lblTestCourse1Title.Size = new System.Drawing.Size(112, 21);
            this.lblTestCourse1Title.TabIndex = 23;
            this.lblTestCourse1Title.Text = "과목 1";
            this.lblTestCourse1Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTestScore9
            // 
            this.tbxTestScore9.Location = new System.Drawing.Point(150, 320);
            this.tbxTestScore9.Name = "tbxTestScore9";
            this.tbxTestScore9.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore9.TabIndex = 29;
            this.tbxTestScore9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore6
            // 
            this.tbxTestScore6.Location = new System.Drawing.Point(150, 239);
            this.tbxTestScore6.Name = "tbxTestScore6";
            this.tbxTestScore6.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore6.TabIndex = 31;
            this.tbxTestScore6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTestNumberTitle
            // 
            this.lblTestNumberTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestNumberTitle.Location = new System.Drawing.Point(20, 33);
            this.lblTestNumberTitle.Name = "lblTestNumberTitle";
            this.lblTestNumberTitle.Size = new System.Drawing.Size(112, 21);
            this.lblTestNumberTitle.TabIndex = 14;
            this.lblTestNumberTitle.Text = "학번";
            this.lblTestNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTestScore8
            // 
            this.tbxTestScore8.Location = new System.Drawing.Point(150, 293);
            this.tbxTestScore8.Name = "tbxTestScore8";
            this.tbxTestScore8.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore8.TabIndex = 30;
            this.tbxTestScore8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore5
            // 
            this.tbxTestScore5.Location = new System.Drawing.Point(150, 212);
            this.tbxTestScore5.Name = "tbxTestScore5";
            this.tbxTestScore5.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore5.TabIndex = 33;
            this.tbxTestScore5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore3
            // 
            this.tbxTestScore3.Location = new System.Drawing.Point(150, 156);
            this.tbxTestScore3.Name = "tbxTestScore3";
            this.tbxTestScore3.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore3.TabIndex = 28;
            this.tbxTestScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore7
            // 
            this.tbxTestScore7.Location = new System.Drawing.Point(150, 266);
            this.tbxTestScore7.Name = "tbxTestScore7";
            this.tbxTestScore7.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore7.TabIndex = 27;
            this.tbxTestScore7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore4
            // 
            this.tbxTestScore4.Location = new System.Drawing.Point(150, 185);
            this.tbxTestScore4.Name = "tbxTestScore4";
            this.tbxTestScore4.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore4.TabIndex = 26;
            this.tbxTestScore4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore2
            // 
            this.tbxTestScore2.Location = new System.Drawing.Point(150, 129);
            this.tbxTestScore2.Name = "tbxTestScore2";
            this.tbxTestScore2.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore2.TabIndex = 25;
            this.tbxTestScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore1
            // 
            this.tbxTestScore1.Location = new System.Drawing.Point(150, 102);
            this.tbxTestScore1.Name = "tbxTestScore1";
            this.tbxTestScore1.Size = new System.Drawing.Size(100, 21);
            this.tbxTestScore1.TabIndex = 24;
            this.tbxTestScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestNumber
            // 
            this.tbxTestNumber.Location = new System.Drawing.Point(150, 34);
            this.tbxTestNumber.Name = "tbxTestNumber";
            this.tbxTestNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxTestNumber.TabIndex = 32;
            // 
            // lblTestAverage
            // 
            this.lblTestAverage.BackColor = System.Drawing.Color.White;
            this.lblTestAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestAverage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestAverage.Location = new System.Drawing.Point(478, 320);
            this.lblTestAverage.Name = "lblTestAverage";
            this.lblTestAverage.Size = new System.Drawing.Size(100, 21);
            this.lblTestAverage.TabIndex = 39;
            this.lblTestAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestAverageTitle
            // 
            this.lblTestAverageTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestAverageTitle.Location = new System.Drawing.Point(349, 319);
            this.lblTestAverageTitle.Name = "lblTestAverageTitle";
            this.lblTestAverageTitle.Size = new System.Drawing.Size(112, 21);
            this.lblTestAverageTitle.TabIndex = 36;
            this.lblTestAverageTitle.Text = "평균";
            this.lblTestAverageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestTotalCount
            // 
            this.lblTestTotalCount.BackColor = System.Drawing.Color.White;
            this.lblTestTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestTotalCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestTotalCount.Location = new System.Drawing.Point(478, 295);
            this.lblTestTotalCount.Name = "lblTestTotalCount";
            this.lblTestTotalCount.Size = new System.Drawing.Size(100, 21);
            this.lblTestTotalCount.TabIndex = 34;
            this.lblTestTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestTotalCountTitle
            // 
            this.lblTestTotalCountTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestTotalCountTitle.Location = new System.Drawing.Point(349, 294);
            this.lblTestTotalCountTitle.Name = "lblTestTotalCountTitle";
            this.lblTestTotalCountTitle.Size = new System.Drawing.Size(112, 21);
            this.lblTestTotalCountTitle.TabIndex = 35;
            this.lblTestTotalCountTitle.Text = "총과목";
            this.lblTestTotalCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestName
            // 
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestName.Location = new System.Drawing.Point(149, 61);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(100, 21);
            this.lblTestName.TabIndex = 38;
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestNameTitle
            // 
            this.lblTestNameTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestNameTitle.Location = new System.Drawing.Point(20, 60);
            this.lblTestNameTitle.Name = "lblTestNameTitle";
            this.lblTestNameTitle.Size = new System.Drawing.Size(112, 21);
            this.lblTestNameTitle.TabIndex = 37;
            this.lblTestNameTitle.Text = "이름";
            this.lblTestNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 422);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tpgDepartment.ResumeLayout(false);
            this.tpgDepartment.PerformLayout();
            this.tpgProfesson.ResumeLayout(false);
            this.tpgProfesson.PerformLayout();
            this.tpgStudent.ResumeLayout(false);
            this.tpgStudent.PerformLayout();
            this.tpgTestScore.ResumeLayout(false);
            this.tpgTestScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirtnMonth;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblBirtnYear;
        private System.Windows.Forms.Label lblBirtnDay;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxContect;
        private System.Windows.Forms.Label lblContect;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgDepartment;
        private System.Windows.Forms.TabPage tpgProfesson;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDepartmentCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Button btnRemoveDepertment;
        private System.Windows.Forms.Button btnRegisterDepartment;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.Button btnRegisterProfessor;
        private System.Windows.Forms.ListBox lbxProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxProfessorNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProfessorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProfessorDepartment;
        private System.Windows.Forms.ComboBox cmbAdvisor;
        private System.Windows.Forms.TabPage tpgTestScore;
        private System.Windows.Forms.Button btnTestRegScore;
        private System.Windows.Forms.Button btnTestSearchStudent;
        private System.Windows.Forms.Label lblTestCourse9Title;
        private System.Windows.Forms.Label lblTestCourse6Title;
        private System.Windows.Forms.Label lblTestCourse3Title;
        private System.Windows.Forms.Label lblTestCourse8Title;
        private System.Windows.Forms.Label lblTestCourse5Title;
        private System.Windows.Forms.Label lblTestCourse2Title;
        private System.Windows.Forms.Label lblTestCourse7Title;
        private System.Windows.Forms.Label lblTestCourse4Title;
        private System.Windows.Forms.Label lblTestCourse1Title;
        private System.Windows.Forms.TextBox tbxTestScore9;
        private System.Windows.Forms.TextBox tbxTestScore6;
        private System.Windows.Forms.Label lblTestNumberTitle;
        private System.Windows.Forms.TextBox tbxTestScore8;
        private System.Windows.Forms.TextBox tbxTestScore5;
        private System.Windows.Forms.TextBox tbxTestScore3;
        private System.Windows.Forms.TextBox tbxTestScore7;
        private System.Windows.Forms.TextBox tbxTestScore4;
        private System.Windows.Forms.TextBox tbxTestScore2;
        private System.Windows.Forms.TextBox tbxTestScore1;
        private System.Windows.Forms.TextBox tbxTestNumber;
        private System.Windows.Forms.Label lblTestAverage;
        private System.Windows.Forms.Label lblTestAverageTitle;
        private System.Windows.Forms.Label lblTestTotalCount;
        private System.Windows.Forms.Label lblTestTotalCountTitle;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblTestNameTitle;
    }
}

