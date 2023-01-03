# FORMATION USINE LOGICIELLE

## Agilit�

* cycles **courts**, **it�ratifs**, incr�mentaux
* adaptation au changement car cycle court et relation client quotidienne
* auto organisation des op�rationnels (pas de la strat�gie)
* recherche de simplicit� (lean)
* accent mis sur la Valeur Ajout�e



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

* git revert