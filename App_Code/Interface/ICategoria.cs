using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste.Entity;

namespace Teste.Interface
{
    public interface ICategoria
    {
        List<EntityCategoria> Listar();

        List<EntityCategoria> Listar(int pCdCategoria);

        void Atualizar(EntityCategoria entity);

        void Incluir(EntityCategoria entity);
    }
}