# MediatekDocuments
Cette application permet de gérer les documents (livres, DVD, revues) d'une médiathèque. Elle a été codée en C# sous Visual Studio 2019. C'est une application de bureau, prévue d'être installée sur plusieurs postes accédant à la même base de données.<br>
L'application exploite une API REST pour accéder à la BDD MySQL. Des explications sont données plus loin, ainsi que le lien de récupération.
<br>MediatekDocuments est un fork de [MediaTekDocuments](https://github.com/CNED-SLAM/MediaTekDocuments).
C'est un projet réalisé dans le cadre du BTS SIO SLAM.<br>

## Présentation
Actuellement L'application permet de faire des recherches et d'afficher différents informations dans les onglets des livres, dvd, revues et peut aussi valider la parution d'une revue. De plus elle peut gérer les commandes de livres, dvd et les abonnements aux revues.
![img1](https://github.com/BHFTY/test3/blob/master/Readme.PNG?raw=true)
<br>L'application est composé d'une seule fenêtre composée de plusieurs onglets.<br>

## Connexion
[Page de presentation du projet](https://cohenrivka2005.wixsite.com/mediatekformation)
L'application propose quatre niveaux d'accès différents, adaptés aux différents services de la médiathèque. Les utilisateurs n’ayant pas d’autorisation spécifique ne peuvent pas accéder au programme. Le personnel du service comptabilité dispose d’un accès limité, lui permettant uniquement de consulter les livres, DVD et revues. L’accueil bénéficie de droits plus étendus, lui permettant de gérer les documents, mais sans possibilité d’effectuer des commandes ou de souscrire des abonnements. Enfin, les bibliothécaires disposent d’un accès complet à l’ensemble des fonctionnalités de l’application.<br><br>
![img2](https://github.com/BHFTY/test3/blob/master/Authetification.PNG?raw=true)<br>

## Les différents onglets
### Onglet 1 : Livres
Cet onglet présente la liste des livres, triée par défaut sur le titre.<br>
La liste comporte les informations suivantes : titre, auteur, collection, genre, public, rayon.
![img3](https://github.com/CNED-SLAM/MediaTekDocuments/assets/100127886/e3f31979-cf24-416d-afb1-a588356e8966)
#### Recherches
<strong>Par le titre :</strong> Il est possible de rechercher un ou plusieurs livres par le titre. La saisie dans la zone de recherche se fait en autocomplétions sans tenir compte de la casse. Seuls les livres concernés apparaissent dans la liste.<br>
<strong>Par le numéro :</strong> il est possible de saisir un numéro et, en cliquant sur "Rechercher", seul le livre concerné apparait dans la liste (ou un message d'erreur si le livre n'est pas trouvé, avec la liste remplie à nouveau).
#### Filtres
Il est possible d'appliquer un filtre (un seul à la fois) sur une de ces 3 catégories : genre, public, rayon.<br>
Un combo par catégorie permet de sélectionner un item. Seuls les livres correspondant à l'item sélectionné, apparaissent dans la liste (par exemple, en choisissant le genre "Policier", seuls les livres de genre "Policier" apparaissent).<br>
Le fait de sélectionner un autre filtre ou de faire une recherche, annule le filtre actuel.<br>
Il est possible aussi d'annuler le filtre en cliquant sur une des croix.
#### Tris
Le fait de cliquer sur le titre d'une des colonnes de la liste des livres, permet de trier la liste par rapport à la colonne choisie.
#### Affichage des informations détaillées
Si la liste des livres contient des éléments, par défaut il y en a toujours un de sélectionné. Il est aussi possible de sélectionner une ligne (donc un livre) en cliquant n'importe où sur la ligne.<br>
La partie basse de la fenêtre affiche les informations détaillées du livre sélectionné (numéro de document, code ISBN, titre, auteur(e), collection, genre, public, rayon, chemin de l'image) ainsi que l'image.
### Onglet 2 : DVD
![img4](https://raw.githubusercontent.com/BHFTY/test3/refs/heads/master/Dvd.PNG).<br>
Cet onglet présente la liste des DVD, triée par titre.<br>
La liste comporte les informations suivantes : titre, durée, réalisateur, genre, public, rayon.<br>
Le fonctionnement est identique à l'onglet des livres.<br>
La seule différence réside dans certaines informations détaillées, spécifiques aux DVD : durée (à la place de ISBN), réalisateur (à la place de l'auteur), synopsis (à la place de collection).
### Onglet 3 : Revues
![img5](https://github.com/BHFTY/test3/blob/master/Revues.PNG?raw=true).<br>
Cet onglet présente la liste des revues, triées par titre.<br>
La liste comporte les informations suivantes : titre, périodicité, délai mise à dispo, genre, public, rayon.<br>
Le fonctionnement est identique à l'onglet des livres.<br>
La seule différence réside dans certaines informations détaillées, spécifiques aux revues : périodicité (à la place de l'auteur), délai mise à dispo (à la place de collection).
### Onglet 4 : Parutions des revues
Cet onglet permet d'enregistrer la réception de nouvelles parutions d'une revue.<br>
Il se décompose en 2 parties (groupbox).
#### Partie "Recherche revue"
Cette partie permet, à partir de la saisie d'un numéro de revue (puis en cliquant sur le bouton "Rechercher"), d'afficher toutes les informations de la revue (comme dans l'onglet précédent), ainsi que son image principale en petit, avec en plus la liste des parutions déjà reçues (numéro, date achat, chemin photo). Sur la sélection d'une ligne dans la liste des parutions, la photo de la parution correspondante s'affiche à droite.<br>
Dès qu'un numéro de revue est reconnu et ses informations affichées, la seconde partie ("Nouvelle parution réceptionnée pour cette revue") devient accessible.<br>
Si une modification est apportée au numéro de la revue, toutes les zones sont réinitialisées et la seconde partie est rendue inaccessible, tant que le bouton "Rechercher" n'est pas utilisé.
#### Partie "Nouvelle parution réceptionnée pour cette revue"
Cette partie n'est accessible que si une revue a bien été trouvée dans la première partie.<br>
Il est possible alors de réceptionner une nouvelle parution en saisissant son numéro, en sélectionnant une date (date du jour proposée par défaut) et en cherchant l'image correspondante (optionnel) qui doit alors s'afficher à droite.<br>
Le clic sur "Valider la réception" va permettre d'ajouter un tuple dans la table Exemplaire de la BDD. La parution correspondante apparaitra alors automatiquement dans la liste des parutions et les zones de la partie "Nouvelle parution réceptionnée pour cette revue" seront réinitialisées.<br>
Si le numéro de la parution existe déjà, il n’est pas ajouté et un message est affiché.
![img6](https://github.com/BHFTY/test3/blob/master/Parutions%20de%20revues.PNG?raw=true)

### Onglet 5 : Commandes Livres
![img7](https://github.com/BHFTY/test3/blob/master/commandelivres.png?raw=true).
#### Recherche
La recherche se fait par le numéro du document ou par le titre du document .
#### Informations détaillées
Les informations détaillées sont les meme que celle de l'onglet livre.
#### Gestion de la commande
Les commandes en cours ou passées sont affichées.<br>
Il est possible de modifier le statut de la commande ou la supprimer si elle n'est pas encore livrée.
#### Nouvelle commande
Il est possible d'ajouter une nouvelle commande en saisissant les informations de commande.<br>
![img8](https://github.com/BHFTY/test3/blob/master/AjoutCommande.PNG?raw=true).

### Onglet 6 : Commandes DVD
L'onglet de Commande de DVD est identique à l'onglet Commandes Livres, à l'exception des informations détaillées spécifiée aux dvd.
![img9](https://github.com/BHFTY/test3/blob/master/CommandeDvd.PNG?raw=true).

### Onglet 7 : Gestion Revues
![img10](https://github.com/BHFTY/test3/blob/master/Abo.png?raw=true)
#### Recherche
La recherche se fait par le numéro de revue ou par le titre d'une revue.
#### Informations détaillées
Les informations détaillées sont identiques à celles de l'onglet Revues.
#### Gestion des abonnements
Les abonnements en cours ou passées sont affichés.<br>
Il est possible de supprimer l'abonnement si aucun numéro n'est paru durant la période d'abonnement.
#### Nouvel abonnement ou renouvellement
Il est possible d'ajouter un nouvel abonnement en saisissant les informations d'abonnement.<br>
![img6](https://github.com/BHFTY/test3/blob/master/CommandeAbonnement.PNG?raw=true).<br>

## La base de données
La base de données 'mediatek86 ' est au format MySQL.<br>
Voici sa structure :<br>
![img7](https://github.com/user-attachments/assets/e91cc3f2-2d3b-42a6-886d-fda1e658b53e)<br>


<br>On distingue les documents "génériques" (ce sont les entités Document, Revue, Livres-DVD, Livre et DVD) des documents "physiques" qui sont les exemplaires de livres ou de DVD, ou bien les numéros d’une revue ou d’un journal.<br>
Chaque exemplaire est numéroté à l’intérieur du document correspondant, et a donc un identifiant relatif. Cet identifiant est réel : ce n'est pas un numéro automatique. <br>
Un exemplaire est caractérisé par :<br>
. un état d’usure, les différents états étant mémorisés dans la table Etat ;<br>
. sa date d’achat ou de parution dans le cas d’une revue ;<br>
. un lien vers le fichier contenant sa photo de couverture de l'exemplaire, renseigné uniquement pour les exemplaires des revues, donc les parutions (chemin complet) ;
<br>
Un document a un titre (titre de livre, titre de DVD ou titre de la revue), concerne une catégorie de public, possède un genre et est entreposé dans un rayon défini. Les genres, les catégories de public et les rayons sont gérés dans la base de données. Un document possède aussi une image dont le chemin complet est mémorisé. Même les revues peuvent avoir une image générique, en plus des photos liées à chaque exemplaire (parution).<br>
Une revue est un document, d’où le lien de spécialisation entre les 2 entités. Une revue est donc identifiée par son numéro de document. Elle a une périodicité (quotidien, hebdomadaire, etc.) et un délai de mise à disposition (temps pendant lequel chaque exemplaire est laissé en consultation). Chaque parution (exemplaire) d'une revue n'est disponible qu'en un seul "exemplaire".<br>
Un livre a aussi pour identifiant son numéro de document, possède un code ISBN, un auteur et peut faire partie d’une collection. Les auteurs et les collections ne sont pas gérés dans des tables séparées (ce sont de simples champs textes dans la table Livre).<br>
De même, un DVD est aussi identifié par son numéro de document, et possède un synopsis, un réalisateur et une durée. Les réalisateurs ne sont pas gérés dans une table séparée (c’est un simple champ texte dans la table DVD).
Enfin, 3 tables permettent de mémoriser les données concernant les commandes de livres ou DVD et les abonnements. Une commande est effectuée à une date pour un certain montant. Un abonnement est une commande qui a pour propriété complémentaire la date de fin de l’abonnement : il concerne une revue.  Une commande de livre ou DVD a comme caractéristique le nombre d’exemplaires commandé et concerne donc un livre ou un DVD.<br>
<br>

## Documentation technique
La documentation technique est disponible sous forme de fichier téléchargeable dans chaque dépôt.

## L'API REST
L'accès à la BDD se fait à travers une API REST protégée par une authentification basique.<br>
Le code de l'API se trouve ici :<br>
[https://github.com/CNED-SLAM/rest_mediatekdocuments<br>](https://github.com/BHFTY/rest_mediatekdocuments)
avec toutes les explications pour l'utiliser (dans le readme).<br>

## Installation de l'application
Ce mode opératoire permet d'installer l'application pour pouvoir travailler dessus.<br>
- Installer Visual Studio 2019 entreprise et les extension Specflow et newtonsoft.json (pour ce dernier, voir l'article "Accéder à une API REST à partir d'une application C#" dans le wiki de ce dépôt : consulter juste le début pour la configuration, car la suite permet de comprendre le code existant).<br>
- Télécharger le code et le dézipper puis renommer le dossier en "mediatekdocuments".<br>
- Récupérer et installer l'API REST nécessaire (https://github.com/BHFTY/rest_mediatekdocuments) ainsi que la base de données (les explications sont données dans le readme correspondant).
- Le projet est en .NET Framework 4.7.2. <br>

## Tests fonctionnels
Pour réaliser les tests il faut tout d'abord installer Specflow dans le extensions de l'application Visual studio.
