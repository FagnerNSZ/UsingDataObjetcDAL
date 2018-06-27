using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace Teste.Entity
{

    [DataObject]
    public class EntityCategoria
    {
        public EntityCategoria()
        {

        }

        private int _CdCategoria;

        [DataObjectField(true, true)]
        public int CdCategoria
        {
            get { return _CdCategoria; }
            set { _CdCategoria = value; }
        }
        private string _NmCategoria;

        [DataObjectField(false)]
        public string NmCategoria
        {
            get { return _NmCategoria; }
            set { _NmCategoria = value; }
        }
        private string _DsCategoria;

        [DataObjectField(false)]
        public string DsCategoria
        {
            get { return _DsCategoria; }
            set { _DsCategoria = value; }
        }
    }
}