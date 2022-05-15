using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace SERVICES
{
    public class PhanSoServiceResult
    {
        //kiểm tra có thành công hay không
        public bool IsSuccess { get; set; }
        public PhanSo Data { get; set; }
        public string Message { get; set; }
        public PhanSoServiceResult(bool isSuccess, PhanSo data, string message)
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
        }
    }
}
