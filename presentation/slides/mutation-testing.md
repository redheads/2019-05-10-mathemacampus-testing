## Mutation testing

Warum?

- Qualität der Tests prüfen

----

### Grundgedanke

<ul>
    <li>Änderung/Bugs in getesteten Code einbauen ("Mutanten")</li>
    <li>Wenn es keinen Einfluss auf das Test-Ergebnis hat, hat der Mutant überlebt -> schlecht</li>
    <li>Wenn der Mutant einen Test fehlschlagen lässt, ist der Mutant tot -> gut</li>
</ul>

----

### Mutation testing frameworks

- Java: [PIT](http://pitest.org/)
- [Stryker](https://stryker-mutator.io/)
  - C#: Stryker.NET
  - Javascript
  - Scala
