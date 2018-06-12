using DataSources1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSources1
{
    public partial class LinqPractice : System.Web.UI.Page
    {
        List<Student> studentList = new List<Student>
            {
                new Student {First="Bob", Last="Jones", ID=111, Age=15, Scores= new List<int> {69, 92, 81, 60}},
                new Student {First="Claire", Last="Simpson", ID=112, Age=17, Scores= new List<int> {75, 84, 83, 39}},
                new Student {First="John", Last="Feetham", ID=113, Age=21, Scores= new List<int> {65, 94, 65, 91}},
                new Student {First="Jonathan", Last="Potts", ID=114, Age=10, Scores= new List<int> {97, 83, 85, 62}},
                new Student {First="Pepe", Last="Garcia", ID=115, Age=20, Scores= new List<int> {35, 72, 91, 70}},
                new Student {First="Samantha", Last="Fakhouri", ID=116, Age=17, Scores= new List<int> {99, 86, 90, 54}},
                new Student {First="Roger", Last="Song", ID=117, Age=19, Scores= new List<int> {60, 72, 64, 45}},
                new Student {First="Hugo", Last="Garcia", ID=118, Age=15, Scores= new List<int> {92, 90, 83, 78}},
                new Student {First="Richard", Last="Ammerman", ID=119, Age=14, Scores= new List<int> {68, 79, 81, 92}},
                new Student {First="Kevin", Last="Adamson", ID=120, Age=11, Scores= new List<int> {68, 71, 81, 79}},
                new Student {First="Jeet", Last="Singh", ID=121, Age=12, Scores= new List<int> {96, 85, 91, 60}}
            };

        List<Staff> teacherList = new List<Staff>
            {
                new Staff {First="Jeet", Last="Singh", ID=900},
                new Staff {First="Richard", Last="Potter", ID=901},
                new Staff {First="Terry", Last="Woodward", ID=902},
                new Staff {First="Bob", Last="Feetham", ID=903},
                new Staff {First="Jane", Last="Feetham", ID=904},
                new Staff {First="Oliver", Last="Jones", ID=905},
                new Staff {First="Rafael", Last="Sacramento", ID=906},
                new Staff {First="John", Last="Smith", ID=907},
                new Staff {First="Pepe", Last="Garcia", ID=908}
            };

        List<Course> courseList = new List<Course>
            {
                new Course{Code="100AB",Name="Intro To Computers",Semester="Fall",Duration=15},
                new Course{Code="101AB",Name="Programming I",Semester="Winter",Duration=15},
                new Course{Code="102AB",Name="Programming II",Semester="Fall",Duration=15},
                new Course{Code="103AB",Name="Database I",Semester="Summer",Duration=5},
                new Course{Code="104AB",Name="Database II",Semester="Summer",Duration=5},
                new Course{Code="303ER",Name="Applied Mathematics",Semester="Summer",Duration=5},
                new Course{Code="304ER",Name="Pure Mathematics",Semester="Fall",Duration=15},
                new Course{Code="588A",Name="English Language",Semester="Winter",Duration=10},
                new Course{Code="589A",Name="English Literature",Semester="Winter",Duration=10},
                new Course{Code="588B",Name="More English Language",Semester="Fall",Duration=10},
                new Course{Code="589B",Name="More English Literatute",Semester="Fall",Duration=10},
                new Course{Code="123Z",Name="Basic Biology",Semester="Winter",Duration=15},
                new Course{Code="123Y",Name="Basic Chemistry",Semester="Fall",Duration=15},
                new Course{Code="123X",Name="Basic Physics",Semester="Summer",Duration=8}
            };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlOptions.SelectedValue)
            {
                case "Students":
                    gvResult.DataSource = studentList;
                    gvResult.DataBind();
                    break;
                case "Teachers":
                    gvResult.DataSource = teacherList;
                    gvResult.DataBind();
                    break;
                case "Courses":
                    gvResult.DataSource = courseList;
                    gvResult.DataBind();
                    break;
            }
        }

        private void printout(List<Student> students)
        {
            foreach (Student s in students)
            {

            }
        }

        protected void ddlDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlDetail.SelectedValue)
            {
                case "Age < 18":
                    var students1 = from s in studentList where s.Age < 18 select s;
                    dvDetail.DataSource = students1;
                    dvDetail.DataBind();
                    break;
                case "Teenagers":
                    var students2 = from s in studentList where s.Age <= 18 && s.Age >= 13
                                    orderby s.Last select s;
                    dvDetail.DataSource = students2;
                    dvDetail.DataBind();
                    break;
                case "Scored > 80 of last test":
                    var students3 = from s in studentList where s.Scores[s.Scores.Count - 1] > 80 select s;
                    dvDetail.DataSource = students3;
                    dvDetail.DataBind();
                    break;
                case "Total scores > 320":
                    var students4 = from s in studentList where s.Scores.Sum() > 320 select s;
                    dvDetail.DataSource = students4;
                    dvDetail.DataBind();
                    break;
                case "No score < 60":
                    var students5 = from s in studentList
                                    where s.Scores[0] >= 60 && s.Scores[1] >= 60
                                    && s.Scores[2] >= 60 && s.Scores[3] >= 60
                                    select s;
                    dvDetail.DataSource = students5;
                    dvDetail.DataBind();
                    
                    //foreach (Student s in students5)
                    //{
                    //    BoundField scores = new BoundField();
                    //    scores.HeaderText = "Scores";
                    //    scores.DataField = s.Scores.ToString();
                    //    dvDetail.Columns.Add(scores);
                    //}
                    
                    break;
                case "Grouped by first letter of the last name":
                    var students6 = from s in studentList where s.Scores.Sum() > 320 select s;
                    dvDetail.DataSource = students6;
                    dvDetail.DataBind();
                    break;
            }
        }
    }
}