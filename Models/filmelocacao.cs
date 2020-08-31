using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


public class filmelocacao


    namespace filmelocacao.Models
    {

        {
            private int _locacaoid;
            private int _filmeid;
            private filme _filme;


            public virtual int id { get; set; }
            public virtual int filmeid;
            public virtual locacaoid;


            public virtual locacao locacao;
            public virtual filme filme;
        }

        End Class
    }