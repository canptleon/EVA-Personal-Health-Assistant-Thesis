using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace auth
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Account",
                url: "Account/Hakkında",
                defaults: new { controller = "Home", action = "Hakkında"}

            );

            routes.MapRoute(
                name: "Account1",
                url: "Account/RandevuAl",
                defaults: new { controller = "Home", action = "RandevuAl" }

            );


            routes.MapRoute(
                name: "Account2",
                url: "Account/",
                defaults: new { controller = "Home", action = "Index" }

            );


            routes.MapRoute(
                 name: "Account3",
                 url: "Account/Doktorlar",
                 defaults: new { controller = "Home", action = "Doktorlar" }

            );
            routes.MapRoute(
                name: "Account4",
                url: "Account/ilacHatırlatıcı",
                defaults: new { controller = "Home", action = "ilacHatırlatıcı" }

            );
            routes.MapRoute(
                name: "Account5",
                url: "Account/TahlilSorgulama",
                defaults: new { controller = "Home", action = "TahlilSorgulama" }

            );

            routes.MapRoute(
                 name: "Account6",
                 url: "Account/BlogSayfası",
                 defaults: new { controller = "Home", action = "BlogSayfası" }

            );

            routes.MapRoute(
                 name: "Account7",
                 url: "Account/SingleBlogSayfası",
                 defaults: new { controller = "Home", action = "SingleBlogSayfası" }

            );

            routes.MapRoute(
                 name: "Account8",
                 url: "Account/SingleBlogSayfasıı",
                 defaults: new { controller = "Home", action = "SingleBlogSayfası" }

            );
            routes.MapRoute(
                 name: "Account9",
                 url: "Account/KullanıcıEkranı",
                 defaults: new { controller = "Home", action = "KullanıcıEkranı" }

            );

            routes.MapRoute(
                 name: "Account10",
                 url: "Account/BizeUlas",
                 defaults: new { controller = "Home", action = "BizeUlas" }

            );

            routes.MapRoute(
                name: "Account11",
                url: "Account/KitleEndeksi",
                defaults: new { controller = "Home", action = "KitleEndeksi" }

            );


            routes.MapRoute(
                name: "Member1",
                url: "Member/BizeUlas",
                defaults: new { controller = "Home", action = "BizeUlas" }

            );

            routes.MapRoute(
                name: "Member2",
                url: "Member/Hakkında",
                defaults: new { controller = "Home", action = "Hakkında" }

            );

            routes.MapRoute(
                name: "Member3",
                url: "Member/KullanıcıEkranı",
                defaults: new { controller = "Home", action = "KullanıcıEkranı" }

            );

            routes.MapRoute(
                name: "Member4",
                url: "Member/",
                defaults: new { controller = "Home", action = "Index" }

            );

            routes.MapRoute(
                name: "Member5",
                url: "Member/KitleEndeksi",
                defaults: new { controller = "Home", action = "KitleEndeksi" }

            );

            routes.MapRoute(
                name: "Member6",
                url: "Member/Doktorlar",
                defaults: new { controller = "Home", action = "Doktorlar" }

            );

            routes.MapRoute(
                name: "Member7",
                url: "Member/ilacHatırlatıcı",
                defaults: new { controller = "Home", action = "ilacHatırlatıcı" }

            );


            routes.MapRoute(
                name: "Member8",
                url: "Member/RandevuAl",
                defaults: new { controller = "Home", action = "RandevuAl" }

            );

            routes.MapRoute(
                name: "Member9",
                url: "Member/TahlilSorgulama",
                defaults: new { controller = "Home", action = "TahlilSorgulama" }

            );


            routes.MapRoute(
                name: "Deneme1",
                url: "Deneme/BizeUlas",
                defaults: new { controller = "Home", action = "BizeUlas" }

            );

            routes.MapRoute(
                name: "Deneme2",
                url: "Deneme/Hakkında",
                defaults: new { controller = "Home", action = "Hakkında" }

            );

            routes.MapRoute(
                name: "Deneme3",
                url: "Deneme/KullanıcıEkranı",
                defaults: new { controller = "Home", action = "KullanıcıEkranı" }

            );

            routes.MapRoute(
                name: "Deneme4",
                url: "Deneme/",
                defaults: new { controller = "Home", action = "Index" }

            );

            routes.MapRoute(
                name: "Deneme5",
                url: "Deneme/KitleEndeksi",
                defaults: new { controller = "Home", action = "KitleEndeksi" }

            );

            routes.MapRoute(
                name: "Deneme6",
                url: "Deneme/Doktorlar",
                defaults: new { controller = "Home", action = "Doktorlar" }

            );

            routes.MapRoute(
                name: "Deneme7",
                url: "Deneme/ilacHatırlatıcı",
                defaults: new { controller = "Home", action = "ilacHatırlatıcı" }

            );


            routes.MapRoute(
                name: "Deneme8",
                url: "Deneme/RandevuAl",
                defaults: new { controller = "Home", action = "RandevuAl" }

            );

            routes.MapRoute(
                name: "Deneme9",
                url: "Deneme/TahlilSorgulama",
                defaults: new { controller = "Home", action = "TahlilSorgulama" }

            );

            routes.MapRoute(
                    name: "Deneme/EditEdit1",
                    url: "Deneme/Edit/BizeUlas",
                    defaults: new { controller = "Home", action = "BizeUlas" }

                );

            routes.MapRoute(
                name: "Deneme/Edit2",
                url: "Deneme/Edit/Hakkında",
                defaults: new { controller = "Home", action = "Hakkında" }

            );

            routes.MapRoute(
                name: "Deneme/Edit3",
                url: "Deneme/Edit/KullanıcıEkranı",
                defaults: new { controller = "Home", action = "KullanıcıEkranı" }

            );

            routes.MapRoute(
                name: "Deneme/Edit4",
                url: "Deneme/Edit/",
                defaults: new { controller = "Home", action = "Index" }

            );

            routes.MapRoute(
                name: "Deneme/Edit5",
                url: "Deneme/Edit/KitleEndeksi",
                defaults: new { controller = "Home", action = "KitleEndeksi" }

            );

            routes.MapRoute(
                name: "Deneme/Edit6",
                url: "Deneme/Edit/Doktorlar",
                defaults: new { controller = "Home", action = "Doktorlar" }

            );

            routes.MapRoute(
                name: "Deneme/Edit7",
                url: "Deneme/Edit/ilacHatırlatıcı",
                defaults: new { controller = "Home", action = "ilacHatırlatıcı" }

            );


            routes.MapRoute(
                name: "Deneme/Edit8",
                url: "Deneme/Edit/RandevuAl",
                defaults: new { controller = "Home", action = "RandevuAl" }

            );

            routes.MapRoute(
                name: "Deneme/Edit9",
                url: "Deneme/Edit/TahlilSorgulama",
                defaults: new { controller = "Home", action = "TahlilSorgulama" }

            );

            routes.MapRoute(
                   name: "Giris/EditEdit1",
                   url: "Giris/Edit/BizeUlas",
                   defaults: new { controller = "Home", action = "BizeUlas" }

               );

            routes.MapRoute(
                name: "Giris/Edit2",
                url: "Giris/Edit/Hakkında",
                defaults: new { controller = "Home", action = "Hakkında" }

            );

            routes.MapRoute(
                name: "Giris/Edit3",
                url: "Giris/Edit/KullanıcıEkranı",
                defaults: new { controller = "Home", action = "KullanıcıEkranı" }

            );

            routes.MapRoute(
                name: "Giris/Edit4",
                url: "Giris/Edit/",
                defaults: new { controller = "Home", action = "Index" }

            );

            routes.MapRoute(
                name: "Giris/Edit5",
                url: "Giris/Edit/KitleEndeksi",
                defaults: new { controller = "Home", action = "KitleEndeksi" }

            );

            routes.MapRoute(
                name: "Giris/Edit6",
                url: "Giris/Edit/Doktorlar",
                defaults: new { controller = "Home", action = "Doktorlar" }

            );

            routes.MapRoute(
                name: "Giris/Edit7",
                url: "Giris/Edit/ilacHatırlatıcı",
                defaults: new { controller = "Home", action = "ilacHatırlatıcı" }

            );


            routes.MapRoute(
                name: "Giris/Edit8",
                url: "Giris/Edit/RandevuAl",
                defaults: new { controller = "Home", action = "RandevuAl" }

            );

            routes.MapRoute(
                name: "Giris/Edit9",
                url: "Giris/Edit/TahlilSorgulama",
                defaults: new { controller = "Home", action = "TahlilSorgulama" }

            );





            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );





        }
    }
}
