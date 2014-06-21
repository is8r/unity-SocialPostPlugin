#import <Social/Social.h>
#import "UnityAppController.h"

//----------------------------------------------------------------------

@interface SocialPostClass : NSObject<UIApplicationDelegate>

+ (void)twitter:(NSString *)s;
+ (void)facebook:(NSString *)s;

@end

//----------------------------------------------------------------------

@implementation SocialPostClass

+ (void)twitter:(NSString *)s
{
    SLComposeViewController *twitterVc = [SLComposeViewController composeViewControllerForServiceType:SLServiceTypeTwitter];
    [twitterVc setInitialText:s];
    UnityAppController *ac = [[UIApplication sharedApplication] delegate];
    [ac.rootViewController presentViewController:twitterVc animated:YES completion:nil];
}

+ (void)facebook:(NSString *)s
{
    SLComposeViewController *facebookVc = [SLComposeViewController composeViewControllerForServiceType:SLServiceTypeFacebook];
    [facebookVc setInitialText:s];
    UnityAppController *ac = [[UIApplication sharedApplication] delegate];
    [ac.rootViewController presentViewController:facebookVc animated:YES completion:nil];
}

//----------------------------------------------------------------------

@end
