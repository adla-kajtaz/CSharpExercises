# Exercise 2

### Roman to Integer

Roman numerals are represented by seven different symbols:

| Symbol | Value |
| ------ | ----- |
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

For example:

- `2` is written as `II` in Roman numerals, just two ones added together.
- `12` is written as `XII`, which is simply `X + II`.
- `27` is written as `XXVII`, which is `XX + V + II`.

Roman numerals are typically written from largest to smallest, left to right. However, there are exceptions where subtraction is used:

1. `I` can be placed before `V (5)` and `X (10)` to make `4` and `9`.
2. `X` can be placed before `L (50)` and `C (100)` to make `40` and `90`.
3. `C` can be placed before `D (500)` and `M (1000)` to make `400` and `900`.

Given a Roman numeral as a string, convert it to an integer.

## Examples

### Example 1:

**Input:**  
`s = "III"`  
**Output:**  
`3`  
**Explanation:**  
`III = 3`

### Example 2:

**Input:**  
`s = "LVIII"`  
**Output:**  
`58`  
**Explanation:**  
`L = 50, V = 5, III = 3`

### Example 3:

**Input:**  
`s = "MCMXCIV"`  
**Output:**  
`1994`  
**Explanation:**  
`M = 1000, CM = 900, XC = 90, IV = 4`
