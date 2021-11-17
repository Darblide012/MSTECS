using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MSTECS.Commun
{

    [Table("mstecs")]
    public class Hability
    {



        [Key]
        [Column("UIid")]
        public Guid IdUser { set; get; }

        [Column("SName")]
        public String Name { set; get; }

        [Column("SLastName")]
        public String LastName { set; get; }

        [Column("SDirection")]
        public String Direction { set; get; }

        [Column("SNumber")]
        public String Number { set; get; }

        [Column("SEmail")]
        public String Email { set; get; }

        [Column("SHability1")]
        public String Habiliti { set; get; }

        [Column("SHablity2")]
        public String Hability2 { set; get; }


        [Column ("SDate")]
        public DateTime DateWrtite { set; get; }

    }


 //   Create database MSTECS 
    
 //   CREATE TABLE mstecs(
 //   SIdUser uniqueidentifier,
 //   SName varchar(20),
 //   SLastName varchar(20),
	//SAddress varchar(20),
	//SNumber varchar(20),
	//SEmail varchar(20),
	//SHabilityOne varchar(20),
	//Shabilitytwo varchar(20),
	//SDate datetime
 //   );

}
