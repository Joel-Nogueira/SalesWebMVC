using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; } //CRIADO PARA SUBSTITUIR O @model SalesWebMvc.Models.Seller NA VIEW SELLER
        public ICollection<Department> Departments { get; set; }// SERÁ UTILIZADO PARA PREENCHER O CAMPO DE SELEÇÃO

    }
}
