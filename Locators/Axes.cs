namespace Locators;

public class Axes
{
    /*
helps create the Xpath for objects that have dynamic attributes for their values.
we need to find a node in the hierarchy with static attribute and build the Xpath based on that node. 

// https://www.saucedemo.com/
 
 DESCENDANT AXES VIEW (use child/grandchild of the current node)
 --------------------------------------------------------------------------------
 //div[@id='login_credentials']/child::* - shows all items of the login credentials section
 //div[@id='login_credentials']/child::h4 - shows item with specific tag
 //div[@id='login_credentials']/child::h4[contains(text(),'Accepted usernames are:')] - allows to filter
 //div[@class='login_credentials_wrap']/descendant::* - works for grandchild as well
 //div[@class='login_credentials_wrap']/descendant::h4[position()=1] - position shows the exact tag
 //div[@class='login_credentials_wrap']/descendant-or-self::* - parent node included
 
 FOLLOWING AXES VIEW (use node that is parallel to the current node)
 --------------------------------------------------------------------------------
 Parallel - node and the current node belong to the same parent.
 //div[@class='login_wrapper-inner']/following-sibling::* - found a parallel sibling node
 //div[@class='login_wrapper-inner']/following-sibling::div/descendant::* - can be used together
 //div[@class='login_wrapper-inner']/following::* - found a parallel sibling node and its child/grandchild
 //div[@class='login_wrapper-inner']/following::br[last()-1] - shows the last tag (-1) in the list of found
 
 ANCESTOR AXES VIEW 
 --------------------------------------------------------------------------------
 //input[@id='login-button']/parent::* - returns the parent node
 //input[@id='login-button']/ancestor::* - all the parent tags
 
  PRECEDING AXES VIEW 
 --------------------------------------------------------------------------------
 Following shows all 'after' nodes, Preceding shows all 'before' nodes from the current
  //div[@class='form_group']/preceding-sibling::* - shows sibling up in the hierarchy
  //div[@class='form_group']/preceding::* - all the previous nodes
   
 */


}