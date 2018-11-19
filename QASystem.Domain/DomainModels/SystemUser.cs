using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QASystem.Models.DomainModels
{
    public class SystemUser : IdentityUser<Guid>
    {
    }
}
