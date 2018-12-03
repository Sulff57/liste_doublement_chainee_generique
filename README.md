Descriptions et instructions du TP :

"TP : Créez une liste chaînée générique
Ahh, un peu de pratique histoire de vérifier que nous avons bien compris les génériques. C'est un concept assez facile à appréhender mais relativement difficile à mettre en œuvre. Quand en ai-je besoin ? Comment ?

Voici donc un petit exercice qui va vous permettre d'essayer de mettre en œuvre une classe générique.

Instructions pour réaliser la première partie du TP
Dans la première partie du TP, nous allons réaliser une liste chaînée. Il s’agit du grand classique des TP d’informatique en C. Je vous rappelle le principe.

La liste chaînée permet de naviguer d’élément en élément. Quand nous sommes sur le premier élément, le suivant est accessible par sa propriété Suivant. Lorsque nous accédons au suivant, l’élément précédent est accessible par la propriété Precedent et le suivant toujours accessible par la propriété Suivant. S’il n’y a pas de précédent ou pas de suivant, l’élément est null :

Image utilisateur
Si on insère un élément à la position 1, les autres se décalent :

Image utilisateur
Voilà, il faut donc créer une telle liste chaînée d’éléments. Le but est bien sûr de faire en sorte que l’élément soit générique.
N’hésitez pas à réfléchir un peu avant de vous lancer. Cela pourrait paraître un peu simpliste, mais en fait cela occasionne quelques nœuds au cerveau.

Toujours est-il que je souhaiterais disposer d’une propriété en lecture seule permettant d’accéder au premier élément ainsi qu’une autre propriété également en lecture seule permettant d’accéder au dernier élément. Bien sûr, il faut pouvoir naviguer d’élément en élément avec des propriétés précédent et suivant.

Il faut évidemment une méthode permettant d’ajouter un élément à la fin de la liste. Nous aurons également besoin d’une méthode permettant d’accéder à un élément à partir de son indice et enfin d’une méthode permettant d’insérer un élément à un indice, décalant tous les suivants. Voilà pour la création de la classe !

Ensuite, notre programme instanciera notre liste chaînée pour lui ajouter les entiers 5, 10 et 4. Puis nous afficherons les valeurs de cette liste en nous basant sur la première propriété et en naviguant d’élément en élément.
Nous afficherons ensuite les différents éléments en utilisant la méthode d’accès à un élément par son indice.
Enfin, nous insérerons la valeur 99 à la première position (position 0), puis la valeur 33 à la deuxième position et enfin la valeur 30 à nouveau à la deuxième position.
Puis nous afficherons tout ce beau monde.

Fin de l’énoncé, ouf ! :)

Pour ceux qui n’ont pas besoin d’aide, les explications sont terminées. Ouvrez vos Visual Studio Express (ou vos Visual Studio si vous êtes riches ;) ) et à vos claviers.

Pour les autres, je vais essayer de vous guider un peu plus en essayant tout de même de ne pas trop vous donner d’indications non plus.

En fait, votre liste chainée n’est pas vraiment une liste, comme pourrait l’être la List<> que nous connaissons. Cette liste chainée possède un point d’entrée qui est le premier élément. L’ajout du premier élément est très simple, il suffit de mettre à jour une propriété. Pour ajouter l’élément suivant, il faut en fait brancher la propriété Suivant du premier élément à l’élément que nous sommes en train d’ajouter. Et inversement, la propriété Precedent de l’élément que nous souhaitons ajouter sera mise à jour avec le premier élément.

On se rend compte que l’élément est un peu plus complexe qu’un simple type. Nous allons donc avoir une classe générique possédant trois propriétés (Precedent, Suivant et Valeur). Et nous aurons également une classe du même type générique possédant la propriété Premier et la propriété Dernier et les méthodes d’ajout, d’obtention de l’élément et d’insertion.

Allez, je vous en ai assez dit. À vous de jouer ! ^^"