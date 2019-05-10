## Test Driven Development (TDD)

---

<img src="images/tdd.png" class="borderless" style="position: relative; top: 10px; left: -400px; height: 400px">

<div style="position: absolute; top: 150px; left: 300px; height: 1000px; width: 800px;">
  <ul class="small-font">
    <li class="fragment" data-fragment-index="0">Test schreiben</li>
    <li class="fragment" data-fragment-index="1">Test sollte fehlschlagen</li>
    <li class="fragment" data-fragment-index="2">minimale (!) Implementierung</li>
    <li class="fragment" data-fragment-index="3">Test grün</li>
    <li class="fragment" data-fragment-index="4">Refactoring (keine Änderung der Funktionalität)</li>
    <li class="fragment" data-fragment-index="5">Repeat</li>
  </ul>
</div>

<div style="position: absolute; top: 630px; right: -16%;">
  <p class="img-src">https://github.com/enolive/tdd-stickers</p>
</div>

---

### Fazit TDD

<ul class="small-font">
<li class="fragment" data-fragment-index="0">Design / Architektur wird von Anfang an **modular**</li>
    <ul>
        <li class="fragment" data-fragment-index="0">vermeiden von zu großen Sprüngen ("Baby Steps")</li>
        <li class="fragment" data-fragment-index="0">vermeiden von zu vielen Abhängigkeiten</li>
        <li class="fragment" data-fragment-index="0">vermeiden (globaler) Zustände</li>
    </ul>
<li class="fragment" data-fragment-index="1">Entstehende Tests sind gleichzeitig:</li>
    <ul>
        <li class="fragment" data-fragment-index="1">Dokumentation</li>
        <li class="fragment" data-fragment-index="1">und Beispiel für Konsumenten der "API"</li>
    </ul>
</ul>
