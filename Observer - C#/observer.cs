using System;
using System.Collections.Generic;
using System.Threading;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    public interface IObserver
    {
        // Recebe uma atualização do subject
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        // Atrela um observador ao subject.
        void Attach(IObserver observer);

        // Desatrela um observador do subject.
        void Detach(IObserver observer);

        // Notifica todos os observadores sobre um evento.
        void Notify();
    }

    // O Subject possui algum estado importante e notifica os observadores quando o estado muda.
    public class Subject : ISubject
    {
        /* Para simplificar, o estado do Subject, que é essencial para todos
        os inscritos, é armazenado nessa variável */
        public int State { get; set; } = -0;

        /* Lista de inscritos. Na vida real, a lista de inscritos pode ser
        armazenada de forma mais compreensível (categorizada por tipo de evento, etc.). */
        private List<IObserver> _observers = new List<IObserver>();

        // Métodos de gerenciamento de inscrição.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Atrelou um observador.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Desatrelou um observador.");
        }

        // Notifica uma atualização para cada inscrito.
        public void Notify()
        {
            Console.WriteLine("Subject: Notificando observadores...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        /* Geralmente, a lógica de inscrição é apenas uma fração do que um Subject
        pode realmente fazer. Os Subjects comumente possuem uma lógica de negócios importante,
        que ativa um método de notificação sempre que algo importante está prestes a
        acontecer (ou após isso). */
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: Fazendo algo importante.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: Meu estado mudou para: " + this.State);
            this.Notify();
        }
    }

    /* Observadores concretos reagem às atualizações informadas pelo Subject que eles
    foram atrelados */
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {            
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reagiu ao evento.");
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reagiu ao evento.");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Código do cliente.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}