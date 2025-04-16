using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Najemun
{
    public partial class Form1: Form
    {
        //인스턴스 필드(변수), 멤버변수
        Department[] departments;
        List<Professor> professors;
        Dictionary<string,Student> students;
        Student selectedStudent = null;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어준다.
        public Form1()
        {
            InitializeComponent();
            
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();


            for (int i = 1; i <= 4; i++)
            {
                cmbYear.Items.Add(i);
            }
            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });
            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");
            //this.cmbYear.Items.Add(1);
            //this.cmbYear.Items.Add(2);
            //this.cmbYear.Items.Add(3);
            //this.cmbYear.Items.Add(4);
            //this.cmbClass.Items.Add("A");
            //this.cmbClass.Items.Add("B");
            //this.cmbClass.Items.Add("C");
            //this.cmbRegStatus.Items.Add("재학");
            //this.cmbRegStatus.Items.Add("졸업");
            //this.cmbRegStatus.Items.Add("휴학");
            //this.cmbRegStatus.Items.Add("퇴학");

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9,
            };
            
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            if(tbxDepartmentCode.Text == "")
            {
                MessageBox.Show("학과코드가 비어있습니다.");
                return;
            }
            if(tbxDepartmentName.Text == "")
            {
                MessageBox.Show("학과이름이 비어있습니다.");
                return;
            }

            for(int i=0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if(index < 0)
                    {
                        index = i;
                    }
                    //break;
                }
                else
                {
                    if(departments[i].Code == tbxDepartmentCode.Text)
                    {
                        MessageBox.Show("동일한 코드는 입력할수 없습니다.");
                        return;
                    }
                }
            }

            if(index < 0)
            {
                MessageBox.Show("학과를 더이상 입력할수 없습니다.");
                return;
            }


            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //추후 삭제 or 주석처리
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}], {dept.Name}");

        }

        private void btnRemoveDepertment_Click(object sender, EventArgs e)
        {
            if(lbxDepartment.SelectedIndex < 0)             //SelectedIndex 몇번째를 선택했는지
            {
                //메세지 띄우기
                MessageBox.Show("삭제될 학과가 선택이 되지 않았습니다.");
                return;
            }

            //is 연산자 , 타입 확인용으로 사용. (Department인지 아닌지)
            if (lbxDepartment.SelectedItem is Department)   //SelectedItem object를 선택
            {
                var target = (Department)lbxDepartment.SelectedItem;
                for(int i=0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1;
            }
            
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    { 
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }
                    ClearStudentInfo();
                    break;
                case 3:
                    tbxTestNumber.Text = "";
                    lblTestName.Text = "";
                    ClearTestScoreInfo();
                    ClearStudentInfo();
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProfessorDepartment.SelectedIndex < 0)
            {
                return;
                
            }
            lbxProfessor.Items.Clear();
            var department = cmbProfessorDepartment.SelectedItem as Department;
            

            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if(professor != null && professor.DepartmentCode == department.Code) 
                                                                                         
                                                                                         
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
            


        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {

            int index = -1;
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("학과를 선택하십시오.");
                return;
            }
            if (false == cmbProfessorDepartment.SelectedItem is Department dept)
            {
                MessageBox.Show("학과정보에 이상 발생");
                cmbProfessorDepartment.Focus();
                return;
            }
            if (tbxProfessorNumber.Text == "")
            {
                MessageBox.Show("교수번호가 비어있습니다.");
                return;
            }
            if (tbxProfessorName.Text == "")
            {
                MessageBox.Show("교수이름이 비어있습니다.");
                return;
            }
            for (int i = 0; i < professors.Count; i++)
            {
                if (professors[i] == null)
                {
                    if (index < 0)
                    {
                        index = i;
                    }
                }
                else
                {
                    if (professors[i].Number == tbxProfessorNumber.Text)
                    {
                        MessageBox.Show("동일한 번호는 입력할수 없습니다.");
                        return;
                    }
                }
            }
            Professor prfe = new Professor();
            prfe.Number = tbxProfessorNumber.Text;
            prfe.Name = tbxProfessorName.Text;
            prfe.DepartmentCode = dept.Code;

            professors.Add(prfe);

            lbxProfessor.Items.Add(prfe);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                return;
            }

            if (lbxProfessor.SelectedItem is Professor)
            {
                var target = (Professor)lbxProfessor.SelectedItem;
                for (int i = 0; i < professors.Count; i++)
                {
                    if (professors[i] != null && professors[i] == target)
                    {
                        professors[i] = null;
                        break;
                    }
                }
                
                lbxProfessor.Items.Remove(target);
            }
        }


        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex < 0)
            {
                return;
            }
            cmbAdvisor.Items.Clear();
            var department = cmbDepartment.SelectedItem as Department;


            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code) 
                                                                                          
                                                                                          
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
        }
        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            tbxAdress.Text = string.Empty;
            tbxContect.Text = string.Empty;
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            //(숙제)
            //tbxNumber의 읽기전용을 해제한다.
            tbxNumber.ReadOnly = false;
            //SelectedStudent를 초기화 한다.
            selectedStudent = null;
            //btnRegister의 글자를 "등록"으로 설정한다.
            btnRegister.Text = "등록";
            //lbxDictionary의 선택을 초기화 한다.
            lbxDictionary.SelectedIndex = -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null) 
            {
                RegisterStudent();
            }
            else
            {
                UpdateStudent(); //call
                
            }
        }

        private void RegisterStudent()
        {
            //학번이 비었거나 8자리가 아닌 경우 처리X
            if (tbxNumber.Text == "")
            {
                MessageBox.Show("학번이 비어있습니다.");
                return;
            }
            if (tbxNumber.Text.Length != 8)
            {
                MessageBox.Show("학번이 8자리가 되어있지 않습니다.");
                return;
            }
            //이름이 비었거나 2자 미만인 경우X
            if (tbxName.Text == "" || tbxName.Text.Length < 2)
            {
                MessageBox.Show("이름이 잘못되었습니다.");
                return;
            }
            var number = tbxNumber.Text.Trim();

            //실제 많이 사용하는 방법1
            if (true == students.ContainsKey(number)) //동일한 학번이 있을때 처리x
            {
                tbxNumber.Focus();
                return;
            }
            Student student = new Student();
            Grade grade = new Grade();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;
            if(int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                if (birthYear < 1899 || birthYear > 9001)
                {
                    MessageBox.Show("생년월일이 유효하지 않습니다.");
                    return;
                }
                //(숙제)유효숫자확인 : 1900~9000
            }
            else
            {
                MessageBox.Show("생년월일이 비어있습니다.");
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                if (birthMonth < 0 || birthMonth > 13)
                {
                    MessageBox.Show("생년월일이 유효하지 않습니다.");
                    return;
                }
                //(숙제)유효숫자확인 : 1~12
            }
            else
            {
                MessageBox.Show("생년월일이 비어있습니다.");
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay < 0 || birthDay > 32)
                {
                    MessageBox.Show("생년월일이 유효하지 않습니다.");
                    return;
                }
                //(숙제)유효숫자확인 : 1~31
            }
            else
            {
                MessageBox.Show("생년월일이 비어있습니다.");
                return;
            }
            //현재시간 : DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            //지도교수를 설정한다. 선택한 지도교수가 없으면 null처리한다.
            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.AdvisorNumber = null;
            }
            else
            {
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }
            //학년을 설정한다. 선택한 학년이 없으면 진행하지 않는다.
            if(cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년이 선택되어 있지 않습니다.");
                return;
            }
            else
            {
                student.Year = int.Parse(cmbYear.Text);
            }
            //반을 설정한다. 선택한 반이 없으면 진행하지 않는다.
            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반이 선택되어 있지 않습니다.");
                return;
            }
            else
            {
                student.Class = cmbClass.Text;
            }
            //재적상태를 설정한다. 선택한 재적상태이 없으면 진행하지 않는다.
            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태가 선택되어 있지 않습니다.");
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.Text;
            }
            //주소를 설정한다.
            student.Adress = tbxAdress.Text.Trim();
            //연락처를 설정한다
            student.Contect = tbxContect.Text.Trim();
            students[number] = student;     //딕셔너리에 데이터 추가방법
            //students.Add(number, student);  //딕셔너리에 데이터 추가방법 (덮어쒸우기)
            lbxDictionary.Items.Add(student);
            grade.StudentNumber = number;
            
        }

        private void UpdateStudent() //define
        {
            var student = (lbxDictionary.SelectedItem as Student);
            //(숙제)
            //수정은 학번을 고칠 수 없다.
            if (tbxNumber.Text != student.Number)
            {
                MessageBox.Show("학번은 수정할 수 없습니다.");
                return;
            }
            //학번을 제외한 모든 사항은 위의 RegisterStudent()와 동일하게 진행한다.
            else
            {
                //이름이 비었거나 2자 미만인 경우X
                if (tbxName.Text == "" && tbxName.Text.Length < 2)
                {
                    MessageBox.Show("이름이 잘못되었습니다.");
                    return;
                }
                student.Name = tbxName.Text.Trim();
                var number = tbxNumber.Text.Trim();
                int birthYear, birthMonth, birthDay;
                if (int.TryParse(tbxBirthYear.Text, out birthYear))
                {
                    if (birthYear < 1899 || birthYear > 9001)
                    {
                        MessageBox.Show("생년월일이 유효하지 않습니다.");
                        return;
                    }
                    //(숙제)유효숫자확인 : 1900~9000
                }
                else
                {
                    MessageBox.Show("생년월일이 비어있습니다.");
                    return;
                }
                if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
                {
                    if (birthMonth < 0 || birthMonth > 13)
                    {
                        MessageBox.Show("생년월일이 유효하지 않습니다.");
                        return;
                    }
                    //(숙제)유효숫자확인 : 1~12
                }
                else
                {
                    MessageBox.Show("생년월일이 비어있습니다.");
                    return;
                }
                if (int.TryParse(tbxBirthDay.Text, out birthDay))
                {
                    if (birthDay < 0 || birthDay > 32)
                    {
                        MessageBox.Show("생년월일이 유효하지 않습니다.");
                        return;
                    }
                    //(숙제)유효숫자확인 : 1~31
                }
                else
                {
                    MessageBox.Show("생년월일이 비어있습니다.");
                    return;
                }
                //현재시간 : DateTime.Now;
                student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

                if (cmbDepartment.SelectedIndex < 0)
                {
                    //cmbDepartment.Focus();
                    //return;
                    student.DepartmentCode = null;
                }
                else
                {
                    student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
                }

                //지도교수를 설정한다. 선택한 지도교수가 없으면 null처리한다.
                if (cmbAdvisor.SelectedIndex < 0)
                {
                    student.AdvisorNumber = null;
                }
                else
                {
                    student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
                }
                //학년을 설정한다. 선택한 학년이 없으면 진행하지 않는다.
                if (cmbYear.SelectedIndex < 0)
                {
                    MessageBox.Show("학년이 선택되어 있지 않습니다.");
                    return;
                }
                else
                {
                    student.Year = int.Parse(cmbYear.Text);
                }
                //반을 설정한다. 선택한 반이 없으면 진행하지 않는다.
                if (cmbClass.SelectedIndex < 0)
                {
                    MessageBox.Show("반이 선택되어 있지 않습니다.");
                    return;
                }
                else
                {
                    student.Class = cmbClass.Text;
                }
                //재적상태를 설정한다. 선택한 재적상태이 없으면 진행하지 않는다.
                if (cmbRegStatus.SelectedIndex < 0)
                {
                    MessageBox.Show("재적상태가 선택되어 있지 않습니다.");
                    return;
                }
                else
                {
                    student.RegStatus = cmbRegStatus.Text;
                }
                //주소를 설정한다.
                student.Adress = tbxAdress.Text;
                //연락처를 설정한다
                student.Contect = tbxContect.Text;
                lbxDictionary.Items.Remove(student);
                students[number] = student;     
                lbxDictionary.Items.Add(student);
                MessageBox.Show("학생정보가 수정 되었습니다.");

            }
                ClearStudentInfo();
        }
        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxDictionary.SelectedIndex < 0)
            {
                return;
            }
            selectedStudent = (lbxDictionary.SelectedItem as Student);

            var student = (lbxDictionary.SelectedItem as Student);
            if (selectedStudent != null)
            {
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i = 0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code == student.DepartmentCode)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cmbAdvisor.Items.Count; i++)
            {
                if ((cmbAdvisor.Items[i] as Professor).Number == student.AdvisorNumber)
                {
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }
            cmbYear.SelectedIndex = student.Year - 1;
            for (int i = 0; i < cmbClass.Items.Count; i++)
            {
                if (cmbClass.Items[i].ToString() == student.Class)
                {
                    cmbClass.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cmbRegStatus.Items.Count; i++)
            {
                if (cmbRegStatus.Items[i].ToString() == student.RegStatus)
                {
                    cmbRegStatus.SelectedIndex = i;
                    break;
                }
            }
            tbxAdress.Text = student.Adress;
            tbxContect.Text = student.Contect;
            tbxName.Text = student.Name;
            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            
            ClearTestScoreInfo();
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
            if (tbxTestNumber.Text != "")
            { 
                if (selectedStudent.Number == tbxTestNumber.Text)
                {
                    lblTestName.Text = selectedStudent.Name;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void ClearTestScoreInfo()
        {
            tbxTestScore1.Text = "";
            tbxTestScore2.Text = "";
            tbxTestScore3.Text = "";
            tbxTestScore4.Text = "";
            tbxTestScore5.Text = "";
            tbxTestScore6.Text = "";
            tbxTestScore7.Text = "";
            tbxTestScore8.Text = "";
            tbxTestScore9.Text = "";
            lblTestTotalCount.Text = "";
            lblTestAverage.Text = "";
        }

        private Student SearchStudentByNumber(string number) 
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            }
            else
            {
                return null;
            }
        }
    }

}
