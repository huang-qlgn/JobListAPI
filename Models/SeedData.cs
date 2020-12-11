﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace JobListAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new JobListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JobListContext>>()))
            {
                if (context.JobList.Any())
                {
                    return;
                }

                context.JobList.AddRange(
                    new JobList
                    {
                        id = 1,
                        isActive = true,
                        title = "Fu Er Dai",
                        location = "Watchtower, Washington",
                        industry = "Rich",
                        picture = "https://picsum.photos/300/300",
                        company = "QUORDATE",
                        email = "frankhorton@quordate.com",
                        jobDesc = "Veniam laborum veniam commodo veniam nisi commodo. Culpa elit qui deserunt adipisicing ad dolor proident laboris adipisicing tempor eu. Elit do non occaecat exercitation ullamco deserunt. Aliquip labore consectetur elit id. Voluptate cupidatat dolore eiusmod labore eu. Consectetur ipsum mollit tempor eiusmod id ipsum sit.\r\n",
                        postedOn = "2020-02-11T04:48:37 -13:00"
                    },
                    new JobList
                    {
                        id = 2,
                        isActive = true,
                        title = "Project Engineer",
                        location = "Concho, Oregon",
                        industry = "Engineering",
                        picture = "https://picsum.photos/300/301",
                        company = "TROPOLIS",
                        email = "frankhorton@tropolis.com",
                        jobDesc = "Pariatur enim labore dolore aliqua voluptate non eiusmod dolor quis quis. Fugiat labore enim laborum labore aliqua occaecat minim ut. Reprehenderit est reprehenderit consectetur do. Nisi qui sint quis culpa velit ea. Commodo veniam sit laborum ipsum in. Cupidatat ullamco voluptate elit et exercitation amet sunt et exercitation voluptate in in nisi velit.\r\n",
                        postedOn = "2020-10-07T08:11:37 -13:00"
                    },
                    new JobList
                    {
                        id = 3,
                        isActive = true,
                        title = "Corporate Advisory",
                        location = "Cliff, Federated States Of Micronesia",
                        industry = "Finance",
                        picture = "https://picsum.photos/300/302",
                        company = "ACIUM",
                        email = "frankhorton@acium.com",
                        jobDesc = "Proident sit nulla id Lorem laboris qui irure occaecat. Labore eu minim fugiat nisi ea sunt velit pariatur officia consectetur ea proident veniam tempor. Elit do cupidatat dolor elit.\r\n",
                        postedOn = "2020-01-12T02:44:00 -13:00"
                    },
                    new JobList
                    {
                        id = 4,
                        isActive = false,
                        title = "Senior Software Engineer",
                        location = "Websterville, Virgin Islands",
                        industry = "IT",
                        picture = "https://picsum.photos/300/303",
                        company = "ANDERSHUN",
                        email = "frankhorton@andershun.com",
                        jobDesc = "Nostrud in fugiat consequat et voluptate pariatur aliquip in quis velit eiusmod. Do in commodo aliquip id exercitation veniam sunt. Nulla dolore ipsum elit veniam ut et et veniam aliqua. Ea Lorem veniam proident aliqua elit elit eiusmod sunt in elit nisi sint.\r\n",
                        postedOn = "2020-05-21T05:47:12 -12:00"
                    },
                    new JobList
                    {
                        id = 5,
                        isActive = false,
                        title = "Marketing Executive",
                        location = "Clarence, Indiana",
                        industry = "Marketing",
                        picture = "https://picsum.photos/300/304",
                        company = "QUARMONY",
                        email = "frankhorton@quarmony.com",
                        jobDesc = "Sunt exercitation duis nostrud culpa Lorem adipisicing deserunt fugiat pariatur ipsum laboris consequat quis velit. Ea commodo anim Lorem laborum cupidatat deserunt aliqua. Adipisicing velit nostrud ipsum proident id consequat aliquip nisi eu nostrud dolor. Culpa nulla sunt aliquip do voluptate ex elit elit commodo nostrud occaecat proident amet. Esse commodo consectetur est labore esse duis sunt labore nulla culpa cillum culpa ex sint. Enim fugiat proident laboris magna laboris est excepteur labore ad non labore ut.\r\n",
                        postedOn = "2020-02-18T02:11:07 -13:00"
                    },
                    new JobList
                    {
                        id = 6,
                        isActive = true,
                        title = "Test Analyst",
                        location = "Sattley, Pennsylvania",
                        industry = "IT",
                        picture = "https://picsum.photos/300/305",
                        company = "UNQ",
                        email = "frankhorton@unq.com",
                        jobDesc = "Officia incididunt ad id laborum aliqua laboris labore amet irure duis et ex consequat elit. Dolore ut consectetur eiusmod deserunt laborum non consectetur magna est incididunt nisi eu magna eiusmod. Do ad dolore adipisicing consectetur incididunt veniam sit cillum. Ullamco exercitation Lorem eiusmod esse minim Lorem veniam aliquip culpa.\r\n",
                        postedOn = "2020-04-23T04:19:40 -12:00"
                    },
                    new JobList
                    {
                        id = 7,
                        isActive = false,
                        title = "Teacher Aide",
                        location = "Hoagland, Oklahoma",
                        industry = "Education",
                        picture = "https://picsum.photos/300/306",
                        company = "CAXT",
                        email = "frankhorton@caxt.com",
                        jobDesc = "Ea nostrud reprehenderit dolore magna duis Lorem qui deserunt ipsum nisi nulla voluptate non. Sunt id reprehenderit nulla officia consequat aute incididunt ut excepteur occaecat excepteur incididunt. Voluptate non nostrud enim proident incididunt commodo culpa enim incididunt ut est sint labore magna. Ipsum aliqua consectetur nostrud laborum minim velit.\r\n",
                        postedOn = "2020-04-24T02:43:09 -12:00"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}