﻿using DDit.Core.Data.Entity.SystemEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDit.Core.Data.IRepositories.ISystemRepositories
{
   public interface IDictionaryCategoryRepository
    {
        List<DictionaryCategory> DiCategoryList();

        void AddDic(DictionaryCategory model);

        void DisabledDic(int btnID);

        void ModifyDic(DictionaryCategory model);

        List<dynamic> GetDictionaryByCategory(DictionaryCategory model);
    }
}
