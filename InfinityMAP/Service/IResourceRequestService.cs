﻿using Domain.Entites;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IResourceRequestService :IService<resourcerequest>
    {
        int GetresourceRequestNumber();
    }
}
