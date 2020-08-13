# monic-solver

This is a simple program designed to help factorise equations in the form of ax^2+bx+c.

```console
$ nonmonicsolver

What should it multiply to?
9

What should it add to?
6

Does x^2 have a coefficient?
1

The two numbers are 3 and 3
Press enter to exit
```

## Limitations

Currently, this program has no support for anything involving decimals.

## What if x^2 doesn't have a coefficient?

In this scenario, there are a few options. Inputting anything that isn't an integer will result in the value for the coefficient of x^2 defaulting to 1. This includes leaving the prompt blank. Inputting 1 will have the same effect.

## What the output means

Following the above example, the original equation would be x^2+6x+9. The output is 3 and 3 and, therefore, the next line of working should be (x+3)(x+3). In an equation involving a coefficient for x^2, this next step is slightly different. For example, 2x^2+9x+9 will output 3 and 6. From there, the next line of working should be 2x^2+3x+6x+9 which should be factorised from there.