using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATFAL360.DTOs
{
    public class AtfalMemberDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string Dila { get; set; }
        public string Muqami { get; set; }


    }

    public class CreateAtfalMemberRequestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string Dila { get; set; }
        public string Muqami { get; set; }

    }

    public class UpdateAtfalMemberRequestModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string Dila { get; set; }
        public string Muqami { get; set; }
    }
}
