using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFormValidation
{
    public class tbl_CategoryValidation
    {
        //whenever we'll update db then this class will be overwritten by new code, so it we can't maintain custom
        //properties here, the solution is, since this is a partial class so create another partial class for custom properties
        //in order to display custom label name use annotation, [Display(PropName = "New PropName")], this will be server side validation,
        //u can however apply client side validation
    }

    [MetadataType(typeof(tbl_CategoryValidation))]
    public partial class tbl_Category{
    }
}