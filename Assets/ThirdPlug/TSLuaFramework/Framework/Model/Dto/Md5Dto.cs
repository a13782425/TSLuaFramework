using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLuaFramework.Model
{
    /// <summary>
    /// 文件MD5校验类
    /// </summary>
    public sealed class Md5Dto
    {
        public Md5Dto()
        {
            Md5InfoDtoList = new List<Md5InfoDto>();
        }

        public int FileCount { get; set; }
        public long FileAllSize { get; set; }

        public List<Md5InfoDto> Md5InfoDtoList { get; set; }

        public sealed class Md5InfoDto
        {
            public string Path { get; set; }
            public string FileName { get; set; }
            public string Md5 { get; set; }
            public long FileSize { get; set; }
        }
    }
}
