using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaasBLL
    {
        public static MaasDTO GetAll()
        {
            MaasDTO dto = new MaasDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.PersonelGetir();
            dto.Aylar = MaasDAO.getAylar();
            dto.Maaslar = MaasDAO.MaasGetir();
            return dto;
        }

        public static void MaasEkle(MAA maas)
        {
            MaasDAO.MaasEkle(maas);
        }
    }
}
