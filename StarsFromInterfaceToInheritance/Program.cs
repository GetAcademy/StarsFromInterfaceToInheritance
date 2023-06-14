using StarsFromInterfaceToInheritance;

StarDemo.Run();

/*
 * 
 * Fra interface til arv:
 *  1: Få til samme som interface
 *     - tomme kropper
 *
 *  2: Hva mer kan vi få til? Effekt utover interface
 *     - flytte row + col - protected
 *     - arve Show
 *     - constructor-chaining
 *
 *  3: Hvordan kan vi få effektene av både arv og interface
 *     fra samme klasse
 *      - virtual = kan overrides
 *      - abstract = må overrides
 *
 *     i interface har ikke metodene kropp
 *     når vi bytter til klasse/arv, så må metodene må ha kropp
 *     MEN: abstract
 */