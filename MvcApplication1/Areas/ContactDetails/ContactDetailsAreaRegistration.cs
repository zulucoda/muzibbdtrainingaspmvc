﻿using System.Web.Mvc;

namespace MvcApplication1.Areas.ContactDetails
{
  public class ContactDetailsAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "ContactDetails";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "ContactDetails_default",
          "ContactDetails/{controller}/{action}/{id}",
          new { action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
