namespace TicketingSystem.Web.Areas.Administration.ViewModel.Categories
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using TicketSystem.Web.Infrastructure.Mapping;
    public class CategoryViewModel : IMapFrom<Category>
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        [UIHint("SingleLineText")]
        public string Name { get; set; }
    }
}