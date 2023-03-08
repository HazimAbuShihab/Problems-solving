# Calculator

Have the function Calculator(str) take the str parameter being passed and evaluate the mathematical expression within in. There can be parenthesis within the string so you must evaluate it properly according to the rules of arithmetic. The string will contain the operators: +,-,/,*. If you have a string like this: #/#*# or #+#*(#)/#, then evaluate from left to right. So divide then multiply, and for the second one multiply, divide, then add. The evaluations will be such that there will not be any decimal operations, so you do not need to account for rounding and whatnot.

## Method
```bash
public static int Calculator(string str)
{

}
```

## Examples

```bash
Input: "2+(3-1)*3"
Output: 8
```
```bash
Input: "(2-0)*(6/2)"
Output: 6
```
```bash
Input: "6*(4/2)+3*1"
Output: 15
```