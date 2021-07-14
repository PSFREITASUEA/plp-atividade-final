from __future__ import annotations
from random import randrange
from typing import List


class ConcreteSubject:

    _state: int = None

    _observers: List[ConcreteObserver] = []

    def attach(self, observer: ConcreteObserver) -> None:
        print("Subject: Atrelado a um observador.")
        self._observers.append(observer)

    def detach(self, observer: ConcreteObserver) -> None:
        self._observers.remove(observer)

    def notify(self) -> None:

        print("Subject: Notificando observadores")
        for observer in self._observers:
            observer.update(self)

    def logic(self) -> None:

        print("\nSubject: Fazendo algo importante")
        self._state = randrange(0, 10)

        print(f"Subject: Meu estado mudou para: {self._state}")
        self.notify()


class ConcreteObserver():

    def update(self, subject: ConcreteSubject) -> None:
        if subject._state > 4:
            print("ConcreteObserver: Reagiu a um evento")
        else:
            print("ConcreteObserver: Não reagiu ao evento")


if __name__ == "__main__":

    subject = ConcreteSubject()

    observer = ConcreteObserver()
    subject.attach(observer)
    subject.logic()
