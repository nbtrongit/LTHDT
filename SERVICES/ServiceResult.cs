using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace SERVICES
{
    //public class PhanSoServiceResult
    public class ServiceResult<T>
    {
        //kiểm tra có thành công hay không
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public ServiceResult(bool isSuccess, T data, string message)
        {
            IsSuccess = isSuccess;
            Data = data;
            ErrorMessage = message;
        }
    }
}
