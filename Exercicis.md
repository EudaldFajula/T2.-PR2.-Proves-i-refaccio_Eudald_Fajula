# T2. PR2. Proves i refaccio

## 1. Quines són les característiques i els escenaris d'ús de les metodologies àgils de desenvolupament de programari? Explica amb detall i posa un exemple.

Les metodologies àgils de desenvolupament de programari, tenen com a característiques la seva capacitat d'adaptació, col·laboració i enfocament en la satisfacció del client.

**Característiques**

- Iteratives i Incrementals: El treball es divideix en cicles curts (sprints) que permeten lliurar de manera regular.
- 
- Col·laboració: Equip de treballs petits i multifuncionals que col·laboren estretament amb els clients.
- 
- Feedback Continu: Les retrospectives i les revisió dels sprints permeten ajustar i millorar contínuament el procés.
- 
- Transparència: Ús de taulers de visualització per mantenir tothom informat sobre l'estat del projecte.
- 
- Flexibilitat:  Capacitat per respondre ràpidament als canvis de requeriments.
- 
**Escenaris d'Ús:**
  
1. Projectes Amb Requeriments Dinàmics: Quan els requeriments poden canviar freqüentment, les metodologies àgils permeten ajustar-se ràpidament a aquests canvis.
2. 
3. Desenvolupament de Productes Nous: Quan el producte encara està en fase de descoberta i necessita canvis ràpids per trobar el seu ajust perfecte.
4. 
5. Entorns Col·laboratius: Organitzacions que valoren la col·laboració constant entre equips i amb clients.
6. 
Exemple:

Imagina una startup de tecnologia que està desenvolupant una nova aplicació mòbil. Al començament, només tenen una idea general del que volen construir. Utilitzant Scrum, el projecte es divideix en sprints de dues setmanes. Al final de cada sprint, l'equip presenta un increment funcional del producte, recullen el seu feedback, i ajusten el següent sprint en funció dels comentaris rebuts. Així, poden adaptar-se ràpidament a les necessitats dels usuaris i llançar versions de l'aplicació de manera regular.

Aquest enfocament àgil permet a la startup adaptar-se a les necessitats canviants del mercat i dels usuaris, mantenint-se competitiva i innovadora.


## 2. Què són els dobles de prova? Explica amb detall els diferents tipus i posa un exemple d’ús per a una solució en C#.

Els dobles de prova (test doubles) són objectes que simulen el comportament d’objectes reals en proves unitàries. S'utilitzen per aïllar la part del sistema que estem provant de les seves dependències, facilitant així la identificació de problemes i errors al codi. Els dobles de prova inclouen diversos tipus: Dummy, Fake, Stub, Spy i Mock.

- **Dummy**: Són objectes que es passen com a arguments, però que no es fan servir. El seu propòsit és simplement emplenar els paràmetres necessaris.

- **Fake**: Són implementacions simples que funcionen en un entorn de prova, però no es fan servir en producció. Un exemple comú és una base de dades en memòria.

- **Stub**: Són objectes que tornen resultats predefinits, controlant el comportament de la dependència i facilitant el testeig de diferents escenaris.

- **Spy**: Són similars als stubs, però a més registren informació sobre com van ser anomenats.

- **Mock**: Són objectes que verifiquen que es van fer certes trucades amb els paràmetres esperats,  validar el comportament de l'objecte que estem provant.

Exemple:

Imaginem que tenim una classe anomenada Customer amb un mètode anomenat makePayment() que depèn d'un objecte ‘CreditCard’ per fer el pagament.

En lloc de proporcionar una implementació real de ‘CreditCard’, podem utilitzar un Dummy per complir amb la signatura del mètode i poder provar la nostra classe Customer de manera aïllada.

## 3. Què és CI/CD? Fes un vídeo explicant les característiques bàsiques, el seu flux de treball i un exemple pràctic d’integració amb GitHub d’una solució en C#.

CI/CD (Integració Contínua i Distribució Contínua) és una pràctica de desenvolupament de programari que permet als equips lliurar canvis de codi de manera més ràpida i segura a través de l'automatització dels processos de construcció, prova i desplegament. 

**Flux de treball:**

- **Commit de Codi:** Els desenvolupadors fan commits de codi en el repositori central (com GitHub).

- Construcció Automàtica:** Un servidor de construcció (com GitHub Actions) compila el codi i crea artefactes de construcció.

- Proves Automàtiques:** Es realitzen proves unitàries, d'integració i funcionals per assegurar que el codi és correcte.

- Revisió de Codi:** Els canvis són revisats i aprovats per altres membres de l'equip.

- Desplegament Automatitzat:** El codi es desplega automàticament en entorns de desenvolupament, prova i producció.

[Video](https://www.youtube.com/watch?v=Avn70USSKdg)

## 4. Aplica els patrons de refacció més habituals en el codi que trobaràs en aquest enllaç. Hauràs de:

En el github.

## 5. Defineix els casos de prova i implements els tests unitaris pel següent problema:

Casos de prova

### Clases de equivalencies:

ClassifyAge: {0 - 120}

IsEven: {infinit}

NameAnalyser: {5}

VerifyColour: {blau, verd}

PersonalityTest: {matí, nit}

### Valors limits

ClassifyAge: {-1 - 121}

IsEven {infinit}

NameAnalyser {-1 - infinit}

### Casos de proba

**ClassyAge:**

Entrada: 0: Resultat esperat: 0

Entrada 1: Resultat esperat: 0

Entrada 18: Resultat esperat: 1

Entrada 65: Resultat esperat: 1

Entrada 66: Resultat esperat: 2

**IsEven**

Entrada 1: Resultat esperat: False

Entrada 2: Resultat esperat: True

**NameAnalyser**

Entrada 1: Resultat esperat: True

Entrada 5: Resultat esperat: False

Entrada 6: Resultat esperat: False

**VerifyColor**

Entrada Res: Resultat esperat: -1

Entrada verd: Resultat esperat: 0

Entrada vermell: Resultat esperat: 1

**PersonalityTest**

Entrada nit: Resultat esperat: 1

Entrada tarda: Resultat esperat: 2

**Codi**

En el github

## 6. Què són els analitzadors de codi? Fes un vídeo explicant les característiques principals i mostra la configuració i funcionament de Sonarqube amb una solució teva en C#.

Els analitzadors de codi són eines de programari dissenyades per examinar el codi font dels programes amb l'objectiu de trobar errors, millorar la qualitat del codi i assegurar-se que compleix amb les normes de codificació establertes.

[video](https://www.youtube.com/watch?v=jABFx6e7Fx8)
