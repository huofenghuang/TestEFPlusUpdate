using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Test
{
    [Table("sys_user")]
    public class SysUser
    {
        /// <summary>
        /// 标识
        /// </summary>
        [Key, Column("id")]
        [MaxLength(36)]
        public string Id { get; set; }


        /// <summary>
        /// 账户状态
        /// </summary>
        [Column("status")]
        [MaxLength(2)]
        [Required]
        public string Status { get; set; }
    }
}
