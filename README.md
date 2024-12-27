# Test-DecoratorPattern

Ce projet est une preuve de concept (POC) qui montre l'utilisation du **pattern Decorator** en C#. Le but est de démontrer comment ce pattern peut être utilisé pour ajouter des fonctionnalités supplémentaires à un objet de manière flexible et sans modifier son code original.

## Lien vers la théorie

Pour une explication détaillée et théorique du pattern Decorator, consultez cet article sur [Refactoring.Guru](https://refactoring.guru/design-patterns/decorator).

## Pourquoi utiliser le pattern Decorator ?

Le **pattern Decorator** est un excellent moyen d'ajouter des comportements ou des fonctionnalités supplémentaires à un objet de manière dynamique et non intrusive. Contrairement à l'héritage, qui peut rendre le code rigide et difficile à maintenir, le pattern Decorator permet de *découpler* les fonctionnalités et de les ajouter ou les retirer en fonction des besoins sans toucher à l'objet de base.

Cela permet de respecter le principe de **responsabilité unique** (SRP - Single Responsibility Principle) en isolant différentes responsabilités dans des classes séparées et en les combinant de manière flexible. Ainsi, chaque décorateur peut être responsable d'un seul aspect ou comportement, permettant une évolutivité et une gestion plus facile des fonctionnalités dans une application.

### Avantages :
- **Découplage** : Le code de l'objet original reste inchangé, ce qui vous permet d'ajouter des fonctionnalités sans risquer de modifier son comportement de manière imprévisible.
- **Responsabilité séparée** : Chaque décorateur peut se concentrer sur un aspect spécifique, ce qui rend le code plus modulaire et plus facile à maintenir.
- **Extensibilité** : Vous pouvez facilement étendre les fonctionnalités de votre système en ajoutant de nouveaux décorateurs sans affecter le reste de l'application.

## Comment utiliser ce POC

1. Clonez ce repository :
   ```bash
   git clone https://github.com/votre-utilisateur/Test-DecoratorPattern.git
