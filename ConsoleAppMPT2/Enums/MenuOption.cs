using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az.Entities;

namespace Turbo.az.Enums
{
    public enum MenuOption : byte
    {

        AddBrand = 1,
        DeleteBrand,
        ShowAllBrands,
        SearchBrandById,
        EditBrand,
        AddModel,
        DeleteModel,
        ShowAllModels,
        SearchModelById,
        EditModel,
        AddAd,
        EditAd,
        DeleteAd,
        SearchAdById,
        ShowAllAds,
        Exit
    }
}

