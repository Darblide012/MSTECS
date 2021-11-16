using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MSTECS.Data
{
    class Database
    {

        

        [Table  "Colummnna"]
        public ColumnAttribute Columnas { get; set; }

        [Column]
        private ColumnAttribute Nombre { get; set; }

        [Column]


    }
}
