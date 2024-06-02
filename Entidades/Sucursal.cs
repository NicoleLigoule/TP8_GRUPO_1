using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Sucursal
    {


        private int Id_Sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_ProvinciaSucursal;
        private string DireccionSucursal;

        public Sucursal()
        {

        }

        public Sucursal( string NombreSucursal, string DescripcionSucursal, string Id_ProvinciaSucursal, string DireccionSucursal)
        {

            int PRo;
            int.TryParse(Id_ProvinciaSucursal, out PRo);
            
            this.NombreSucursal = NombreSucursal;
            this.DescripcionSucursal = DescripcionSucursal;
            this.Id_ProvinciaSucursal = PRo;
            this.DireccionSucursal = DireccionSucursal;
        }
        public void setId_Sucursal(int ID)
        {
            Id_Sucursal = ID;
        }
        public int GetId_Sucursal()
        {
            return Id_Sucursal;
        }
        public void setNombreSucursal(string NombreSucursa)
        {
            NombreSucursal = NombreSucursa;
        }
        public string GetNombreSucursal()
        {
            return NombreSucursal;
        }
        public void setDescripcionSucursal(string DescripcionSucursa)
        {
            DescripcionSucursal = DescripcionSucursa;
        }
        public string GetDescripcionSucursal()
        {
            return DescripcionSucursal;
        }
        public void setId_ProvinciaSucursal(int ID)
        {
            Id_ProvinciaSucursal = ID;
        }
        public int GetId_ProvinciaSucursal()
        {
            return Id_ProvinciaSucursal;
        }
        public void setDireSucursal(string DireSucur)
        {
            DireccionSucursal = DireSucur;
        }
        public string GetDireSucur()
        {
            return DireccionSucursal;
        }

    }
}
