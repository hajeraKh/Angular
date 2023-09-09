using ExamAngular01.Models;
using System.ComponentModel.DataAnnotations;

namespace ExamAngular01.ViewModels
{
    public class candidateVM
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public string PhoneNo { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }
        public bool? Fresher { get; set; }
        public string skillsStringify { get; set; }
        public Skill[] SkillList { get; set; }
    }

}
