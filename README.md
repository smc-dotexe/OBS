# OBS

## Implement a component that reduces a character sequence to its significant elements.  
* Inputs and outputs are case-sensitive 
* Inputs will be composed of uppercase and lowercase characters.  
    * Example input: **aBccDdCasdeE…** (and so on, for 100kb of character input) 

* Adjacent elements of similar character, but opposing case, are insignificant and must not be represented in the output. 
    * Given “caAB”, “aA” is insignificant and the output reduces to “cB” 
    * Given “cGgGB”, “GgG” has two characters that are insignificant and reduces to “cGB” 

* If removing insignificant elements causes new similar/opposing adjacency, the new adjacency is also insignificant and must be removed. 
    * Given “aByYbf”, “yY” gets removed and now the value is “aBbf”, and additionally “Bb” gets removed to set the value to “af”, which cannot be reduced any more. 
