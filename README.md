# FORMATION USINE LOGICIELLE

## Agilité

* cycles **courts**, **itératifs**, incrémentaux
* adaptation au changement car cycle court et relation client quotidienne
* auto organisation des opérationnels (pas de la stratégie)
* recherche de simplicité (lean)
* accent mis sur la Valeur Ajoutée



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
