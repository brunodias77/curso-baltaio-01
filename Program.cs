using System;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao a objetos"));
            articles.Add(new Article("Artigo sobre Nodejs", "orientacao a objetos usando typescript"));
            //foreach (var item in articles)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine(item.Url);
            //};
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundameentos-oop");
            var courseDotNet = new Course("Fundamentos c#", "Conhecendo a lingugem da Microsoft");
            var courseNodejs = new Course("Fundamentos do Nodejs", "fundameentos-node");
            var courseReactjs = new Course("Fundamentos Reactjs", "fundameentos-react");
            courses.Add(courseNodejs);
            courses.Add(courseReactjs);
            courses.Add(courseOOP);
            courseNodejs.AddNotification(new Notification());
            var careers = new List<Career>(); // Lista de carreiras
            var careerDotNet = new Career("Especilista .Net", "especialista-dotnet"); // Uma carreira
            var careerItem2 = new CareerItem(2, "Fundamentos de C#", "Vamos conhecer a linguagem de programação c#", courseDotNet); // criando um item de uma carreira
            var careerItem1 = new CareerItem(1, "Comece por aqui", "o comeco da carreira de um desenvolvedor", courseNodejs); // criando um item de uma carreira
            var careerItem3 = new CareerItem(3, "Banco de dados", "Aprendendo o SqlServer", null); // criando um item de uma carreira
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem1); // o item de carreira para uma carreira !
            careers.Add(careerDotNet); // add uma carreira para uma lista de carreiras !

            foreach (var career in careers)
            {
                Console.WriteLine("entrou no foreach");
                Console.WriteLine(career.Title);
                Console.WriteLine(career.Items);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{ item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"Error: {notification.Property} - {notification.Message} - {item.Title}");
                    }
                }
                var payPalSubscription = new PaypalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }


        }
    }
}

