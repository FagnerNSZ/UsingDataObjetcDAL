using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Interface;
using Teste.Entity;
using Teste.DAL;
using System.ComponentModel;

namespace Teste.BLL
{
    [DataObject]
    public class BLLCategoria: ICategoria
    {
        public  BLLCategoria() { }

        private DALCategoria dal = DALCategoria.Current;



        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<EntityCategoria> Listar()
        {
            return dal.Listar();
        }

        public List<EntityCategoria> Listar(int pCdCategoria)
        {
            return dal.Listar(pCdCategoria);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Atualizar(EntityCategoria entity)
        {
            dal.Atualizar(entity);
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Incluir(EntityCategoria entity)
        {
            dal.Incluir(entity);
        }
    }
}