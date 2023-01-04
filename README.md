# FORMATION USINE LOGICIELLE

## Agilité

* cycles **courts**, **itératifs**, incrémentaux
* adaptation au changement car cycle court et relation client quotidienne
* auto organisation des opérationnels (pas de la stratégie)
* recherche de simplicité (lean)
* accent mis sur la Valeur Ajoutée

### SCRUM

![schéma scrum](https://img-0.journaldunet.com/zGMKc9KYzFcZR58Yu7LXfA5MvKo=/1080x/smart/f31c54febeda4155baba226c47eba131/ccmcms-jdn/19486383.jpg)

* rôles SCRUM
  - product owner
  - scrum master
  - agile process manager
  - production team


## DevOps

1. extension de l'agilité aux admins sys
2. améliorer la collaboration entre dev et ops
3. mouvement culturel (état d'esprit / méthodes / pratiques / process / outil)


## GIT

### création de commits

* `git init` : création dépôt .git
* `git config --global user.name` : config métadonée utilisateur
* `git add path | . | -i`: ajout à l'index
* git commit -m


### synchronisation

1. `ssh-keygen` : création de clés dans ~/.ssh
2. sur gitlab, ajouter la clé pub dans user -> preferences -> ssh key
3. dans ~/.ssh/config:

```
Host gitlab.myusine.fr
 IdentityFile "/c/Users/<user>/.ssh/<key>"
 UserKnownHostsFile /dev/null
 StrictHostKeyChecking no
```

4. `git remote add origin <address>`
5. `git push origin master`

### actions négatives

* git checkout
  * git checkout [HEAD] -- <path> : écrasement du fichier en paramètre par la version du dépôt 
  * git checkout <hash> : écrasement complet de la copie de travail avec l'état d'un commit en mode détaché, hors branche
  * git checkout <branch_name>: changement de branche

* git reset -- <path>: désindéxer

* git rm 
  * git rm <path> : suppression de la copie de travail et du dépôt
  * git rm --cached <path>: suppression uniquement du dépôt


* git reset
  1. déplacment de HEAD
  2. suppressions des commits auparavant devant le nouveau head
  3. niveaux de reset
  
  | option |   copie   |   index   |
  |--------|-----------|-----------|
  | soft   |  conservée| conservé  |
  | mixed  |  conservée| écrasé    |
  | hard   |  écrasée  | écrasé    |

  4. réécris l'historique: ne pas reset un commit déjà poussé
  5. backup strategy: on retrouve le commits disparu dans le **reflog**

* git revert [ HEAD ]
  1. création d'un commit qui annule les modifications du commit en paramètre
  2. conserve l'hisorique: à préférer à reset si commit déjà poussé
  3. création de commit => message => --no-edit ajoute un message standard
  4. [voir ici](https://www.atlassian.com/git/tutorials/undoing-changes/git-revert)

## dépôts distants

* `git clone`: synchroniser en local à partir d'un dépôt distant
* `git remote add`: synchroniser le dépôt distant à partir du dépôt local
* `git push [repo_name] [branch_name]`: envoyer sur dépôt distant
   - push -u : renseigner le dépôt et la branche par défaut
* `git fetch`: récupérer les commit distants dans la branche de suivi repo_name/branch_name
   - fetch --all : récupère toutes les branches de tous les dépôts
* `git pull`: git fetch + git merge