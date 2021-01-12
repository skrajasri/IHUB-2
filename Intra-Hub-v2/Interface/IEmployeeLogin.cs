using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intra_Hub_v2.ViewModel.OutModel;
using Intra_Hub_v2.ViewModel.InModel;

namespace Intra_Hub_v2.Interface
{
    public interface IEmployeeLogin
    {
        List<API0001_OutModel> getLoginDetails(API0001_InModel api0001_inValue);
    }
}