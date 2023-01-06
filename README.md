# FORMATION USINE LOGICIELLE

## Agilit�

* cycles **courts**, **it�ratifs**, incr�mentaux
* adaptation au changement car cycle court et relation client quotidienne
* auto organisation des op�rationnels (pas de la strat�gie)
* recherche de simplicit� (lean)
* accent mis sur la Valeur Ajout�e

### SCRUM

![sch�ma scrum](https://img-0.journaldunet.com/zGMKc9KYzFcZR58Yu7LXfA5MvKo=/1080x/smart/f31c54febeda4155baba226c47eba131/ccmcms-jdn/19486383.jpg)

* r�les SCRUM
  - product owner
  - scrum master
  - agile process manager
  - production team


## DevOps

1. extension de l'agilit� aux admins sys
2. am�liorer la collaboration entre dev et ops
3. mouvement culturel (�tat d'esprit / m�thodes / pratiques / process / outil)


## GIT

### cr�ation de commits

* `git init` : cr�ation d�p�t .git
* `git config --global user.name` : config m�tadon�e utilisateur
* `git add path | . | -i`: ajout � l'index
* git commit -m


### synchronisation

1. `ssh-keygen` : cr�ation de cl�s dans ~/.ssh
2. sur gitlab, ajouter la cl� pub dans user -> preferences -> ssh key
3. dans ~/.ssh/config:

```
Host gitlab.myusine.fr
 IdentityFile "/c/Users/<user>/.ssh/<key>"
 UserKnownHostsFile /dev/null
 StrictHostKeyChecking no
```

4. `git remote add origin <address>`
5. `git push origin master`

### actions n�gatives

* git checkout
  * git checkout [HEAD] -- <path> : �crasement du fichier en param�tre par la version du d�p�t 
  * git checkout <hash> : �crasement complet de la copie de travail avec l'�tat d'un commit en mode d�tach�, hors branche
  * git checkout <branch_name>: changement de branche

* git reset -- <path>: d�sind�xer

* git rm 
  * git rm <path> : suppression de la copie de travail et du d�p�t
  * git rm --cached <path>: suppression uniquement du d�p�t


* git reset
  1. d�placment de HEAD
  2. suppressions des commits auparavant devant le nouveau head
  3. niveaux de reset
  
  | option |   copie   |   index   |
  |--------|-----------|-----------|
  | soft   |  conserv�e| conserv�  |
  | mixed  |  conserv�e| �cras�    |
  | hard   |  �cras�e  | �cras�    |

  4. r��cris l'historique: ne pas reset un commit d�j� pouss�
  5. backup strategy: on retrouve le commits disparu dans le **reflog**

* git revert [ HEAD ]
  1. cr�ation d'un commit qui annule les modifications du commit en param�tre
  2. conserve l'hisorique: � pr�f�rer � reset si commit d�j� pouss�
  3. cr�ation de commit => message => --no-edit ajoute un message standard
  4. [voir ici](https://www.atlassian.com/git/tutorials/undoing-changes/git-revert)

## d�p�ts distants

* `git clone`: synchroniser en local � partir d'un d�p�t distant
* `git remote add`: synchroniser le d�p�t distant � partir du d�p�t local
* `git push [repo_name] [branch_name]`: envoyer sur d�p�t distant
   - push -u : renseigner le d�p�t et la branche par d�faut
* `git fetch`: r�cup�rer les commit distants dans la branche de suivi repo_name/branch_name
   - fetch --all : r�cup�re toutes les branches de tous les d�p�ts
* `git pull`: git fetch + git merge

## tags

* �tiquette associ�e � un commit
* possibilit� d'ajouter un message avec l'option -a [^1]
* `git tag -a v2.0 [HEAD] -m "msg"`
  - `git tag -af v2.0 -m "msg"`: si on doit d�placer le tag sur un commit plus r�cent ou pertinent

* `git tag -d <tag_name>`: supprimer un tag
* `git push -d <tag_name> | <branch_name>`: supprimer un tag / une branche distante

[^1]: appel� tag annot�


## rebase

* but: d�pacer une branche sur un autre commit de base
* use case: mettre �  jour une branche de fonctionnalit� avec des commits r�cents 
  de la branche de base sans int�grer directement ces commits � la branche de f.
* ATTENTION: r��criture d'url
* d�roulement:
  - chaque commit de la branche � rebaser (f.) est ajout� au dessus du nouveau commit de base
  - possibilit� de conflit
  - si plusieurs commit vont entrer en conflit successivement avec le m�me fichier du commit de base
    on peut entrer rebase --skip et r�soudre le conflit en un coup avec le dernie commit concern�
  - r�solution de conflit: accepter la fusion  + `git add` + `git rebase --continue`
  - si le rebase est trop compliqu�: `git rebase --abort`


## git stash

* il est dangereux ou impossible de changer de branche avec des modifications non commit�s 
  (fichiers Modified (M) ou Utracked (U ou ??))
* commiter ces modifs si elles ne sont qu'un WIP est d�conseill�
* supprimer ces modifs pour pouvoir r�aliser le git checkout est d�conseill�
* on utilise `git stash`

* `git stash -u`: place les modif M et U dans le stash

* ATTENTION: ne pas appliquer un stash pr�vu pour une branche sur une autre
  workaround: `git reset --hard HEAD` pour revenir avant le mauvais `stash pop` ou `stash apply`
* `git stash pop` sans argument peut �tre hasardeux si on ne connait pas le contenu du stash