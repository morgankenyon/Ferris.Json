## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.FerrisSingleProperty()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+38],xmm4
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rcx,221F0C01E00
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC93F066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       jne       short M00_L00
       mov       rcx,221F0C01E48
       mov       rcx,[rcx]
       jmp       short M00_L03
M00_L00:
       cmp       dword ptr [rsp+48],1
       je        near ptr M00_L05
       mov       edi,[rsp+48]
       test      edi,edi
       jl        near ptr M00_L06
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        near ptr M00_L07
       cmp       [rbp+8],edi
       je        short M00_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       cmp       edi,r8d
       cmovg     edi,r8d
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L04
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsp+38],r14
M00_L02:
       mov       ecx,[rsp+48]
       mov       [rsp+4C],ecx
       mov       rcx,[rsp+38]
M00_L03:
       mov       rdx,rsi
       call      qword ptr [7FFC943C5EF0]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,51B4A2A4
       mov       r9d,80824C0D
       call      qword ptr [7FFC943FF9A8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       call      qword ptr [7FFC94065BD8]
       jmp       short M00_L01
M00_L05:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
       jmp       short M00_L03
M00_L06:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC9414ED48]
       int       3
M00_L07:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+38],rax
       jmp       near ptr M00_L02
; Total bytes of code 382
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rdi,rdi
       jne       near ptr M01_L12
M01_L00:
       xor       r12d,r12d
M01_L01:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L10
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L10
       mov       rbp,rax
M01_L02:
       mov       [rsp+38],rdi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        near ptr M01_L11
       mov       rax,[rsp+38]
M01_L03:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L16
       cmp       r12d,2
       je        near ptr M01_L18
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L14
       mov       r12,[rbp+8]
M01_L04:
       xor       ebx,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L07
M01_L05:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       je        short M01_L08
M01_L06:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L05
M01_L07:
       mov       rdx,[rsp+50]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rsi+10],eax
       mov       eax,[rsp+64]
       mov       [rsi+14],eax
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       test      r15d,r15d
       jne       near ptr M01_L20
       test      r14,r14
       jne       near ptr M01_L21
M01_L09:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC941A4F18]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M01_L06
M01_L10:
       mov       rcx,rbp
       call      qword ptr [7FFC93F06658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L02
M01_L11:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
       jmp       near ptr M01_L03
M01_L12:
       test      bl,1
       je        short M01_L15
       mov       rcx,221F0C00590
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFC940FC1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
       mov       r13d,1
       mov       r12d,2
M01_L13:
       cmp       byte ptr [rsp+0D8],0
       jne       near ptr M01_L22
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFC941A67A8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L04
M01_L15:
       mov       r12d,1
       jmp       short M01_L13
M01_L16:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC941A4FC0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L17
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFC941A67A8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L17:
       jmp       near ptr M01_L04
M01_L18:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC941A4FC0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L19
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFC941A67A8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L19:
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,r10
       mov       rdx,rdi
       mov       r8d,r13d
       call      qword ptr [7FFC93F06538]
       test      eax,eax
       je        near ptr M01_L06
       mov       r10,[rsp+40]
       test      r14,r14
       je        near ptr M01_L09
M01_L21:
       mov       rcx,r10
       call      qword ptr [7FFC9426D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L06
       mov       r10,[rsp+40]
       jmp       near ptr M01_L09
M01_L22:
       mov       rcx,rdi
       mov       edx,2A
       cmp       [rcx],ecx
       call      qword ptr [7FFC93FB6160]; System.String.EndsWith(Char)
       test      eax,eax
       je        near ptr M01_L01
       mov       r8d,[rdi+8]
       dec       r8d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC93FB7240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       mov       r15d,1
       jmp       near ptr M01_L00
; Total bytes of code 801
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,248
       vzeroupper
       xor       eax,eax
       mov       [rsp+0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M02_L01:
       vmovdqa   xmmword ptr [rsp+rax+240],xmm4
       vmovdqa   xmmword ptr [rsp+rax+250],xmm4
       vmovdqa   xmmword ptr [rsp+rax+260],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rsp+240],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L98
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L29
M02_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,r13
       jne       near ptr M02_L99
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       jne       short M02_L05
       xor       ecx,ecx
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L91
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC941931B0]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[r14+18]
       jmp       short M02_L04
M02_L06:
       cmp       r15,r13
       jne       near ptr M02_L179
       mov       rcx,r14
       cmp       qword ptr [rcx+38],0
       je        short M02_L09
M02_L07:
       mov       rdx,[r14+38]
       mov       rax,[rdx+18]
M02_L08:
       mov       r10,rax
       mov       [rsp+0C0],r10
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M02_L181
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1D0]
       mov       rcx,r10
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC93F066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+1E0],0
       jne       near ptr M02_L39
       mov       rdx,221F0C01E48
       mov       rax,[rdx]
       jmp       near ptr M02_L13
M02_L09:
       mov       rcx,[r14+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+0A8],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+0A8]
       mov       [rsp+210],rdx
       mov       [rsp+218],rax
       lea       rdx,[rsp+1F0]
       mov       [rsp+20],rdx
       mov       edx,[r14+50]
       lea       rcx,[rsp+210]
       lea       r8,[rsp+208]
       lea       r9,[rsp+200]
       call      qword ptr [7FFC94215DE8]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+1F8]
       mov       [rsp+1E8],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0B0],rax
       mov       r9,[r14+30]
       mov       rcx,rax
       mov       rdx,[rsp+1E8]
       mov       r8d,[rsp+1F0]
       call      qword ptr [7FFC941A7A80]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r14+38]
       mov       rdx,[rsp+0B0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L10:
       mov       rdx,r10
       call      qword ptr [7FFC94065BD8]
M02_L11:
       mov       rcx,[rsp+90]
       mov       [rsp+1D0],rcx
M02_L12:
       mov       ecx,[rsp+1E0]
       mov       [rsp+1E4],ecx
       mov       rax,[rsp+1D0]
M02_L13:
       mov       rdx,rax
M02_L14:
       mov       [rsp+0B8],rdx
       test      r12,r12
       je        near ptr M02_L89
       mov       rcx,22180200020
       mov       rax,[rsp+0C0]
       cmp       rax,rcx
       je        near ptr M02_L43
       mov       rcx,221802087C0
       cmp       rax,rcx
       je        near ptr M02_L43
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M02_L100
       mov       rcx,rax
       call      qword ptr [7FFC93F07330]; System.RuntimeType.GetBaseType()
       mov       rcx,221802021B8
       cmp       rax,rcx
       je        near ptr M02_L101
M02_L15:
       mov       rcx,22180208828
       mov       r8,[rsp+0C0]
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,22180208660
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,22180204FC0
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,22180208850
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,22180205F58
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,22180208878
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,221802088A0
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,221802088C8
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,221802088F0
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180205718
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180208918
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180208940
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180208968
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180204B88
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,22180208990
       cmp       r8,rcx
       jne       near ptr M02_L71
M02_L16:
       xor       ecx,ecx
       mov       [rsp+220],rcx
       mov       rcx,221F0C01DF8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC94189EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+228],rax
       test      rax,rax
       je        near ptr M02_L103
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L17:
       mov       [rsp+238],rdx
       mov       [rsp+240],eax
       xor       ecx,ecx
       mov       [rsp+230],ecx
       mov       byte ptr [rsp+234],0
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rax,[rsp+238]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L104
       mov       rcx,2218020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+230]
       inc       ecx
       mov       [rsp+230],ecx
M02_L18:
       cmp       r15,r13
       jne       near ptr M02_L106
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L26
M02_L19:
       cmp       byte ptr [rsp+234],0
       jne       near ptr M02_L107
M02_L20:
       test      r15,r15
       je        near ptr M02_L107
       mov       r8d,[rsp+230]
       cmp       r8d,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L107
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+230]
       add       edx,[r15+8]
       mov       [rsp+230],edx
M02_L21:
       mov       edx,[rsp+230]
       cmp       edx,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,edx
       cmp       eax,2
       jb        near ptr M02_L108
       mov       rdx,22180208814
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       edx,[rsp+230]
       add       edx,2
       mov       [rsp+230],edx
M02_L22:
       mov       [rsp+150],r12
       cmp       byte ptr [rsp+234],0
       jne       near ptr M02_L118
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC93FB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L55
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC93FB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L64
M02_L23:
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC93FB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rdx,[rsp+238]
       mov       r9d,ecx
       lea       rdx,[rdx+r9*2]
       mov       r9d,[rsp+240]
       sub       r9d,ecx
       xor       ecx,ecx
       mov       r8,offset MT_System.UInt16
       cmp       [rax],r8
       jne       near ptr M02_L40
       add       rax,8
       movzx     ecx,word ptr [rax]
       mov       r8d,ecx
       mov       r11d,ecx
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rax,7FFCC8F187A0
       add       r8,[rax+r11*8]
       sar       r8,20
       cmp       r8d,r9d
       jg        near ptr M02_L110
       mov       [rsp+140],r8d
       mov       [rsp+138],rdx
       movsxd    r9,r8d
       lea       rdx,[rdx+r9*2]
       cmp       ecx,0A
       jb        near ptr M02_L34
       cmp       ecx,64
       jb        short M02_L25
       mov       r9,221F0C00290
       mov       r14,[r9]
M02_L24:
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r9d,ecx
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       ecx,r8d
       mov       r8,r14
       shl       ecx,2
       mov       ecx,[r8+rcx+10]
       mov       [rdx],ecx
       cmp       r9d,64
       mov       ecx,r9d
       jae       short M02_L24
M02_L25:
       cmp       ecx,0A
       jb        near ptr M02_L34
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r9,221F0C00290
       mov       r14,[r9]
       shl       ecx,2
       mov       ecx,[r14+rcx+10]
       mov       [rdx],ecx
       jmp       near ptr M02_L35
M02_L26:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L105
       mov       rcx,r15
       call      qword ptr [7FFC94065050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L27:
       mov       [rsp+158],r15
       mov       [rsp+160],eax
       lea       rcx,[rsp+158]
       call      qword ptr [7FFC941A6B50]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L19
M02_L28:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M02_L03
M02_L29:
       mov       rdx,rdi
       mov       rcx,22180200C60
       call      qword ptr [7FFC93FB6DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,221802089B8
       mov       r8,221802089D0
       call      qword ptr [7FFC93FB6B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,248
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L30:
       xor       ecx,ecx
       mov       [rsp+148],rcx
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rax,[rsp+238]
       mov       [rsp+0D8],rax
       mov       [rsp+0E0],ecx
       lea       rcx,[rsp+0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r14,[rsp+228]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+220],ymm0
       vmovdqu   xmmword ptr [rsp+238],xmm0
       test      r14,r14
       je        near ptr M02_L33
       mov       rcx,221F0C01DF8
       mov       r15,[rcx]
       mov       ecx,[r14+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFC93EF5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L115
M02_L31:
       xor       eax,eax
       mov       dword ptr [rsp+130],1
       cmp       [rcx+8],r12d
       jbe       short M02_L32
       mov       dword ptr [rsp+134],1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [r14+8],edx
       jne       near ptr M02_L94
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L182
       mov       edx,r12d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+134]
       jne       near ptr M02_L116
M02_L32:
       mov       rcx,221F0C005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L131
M02_L33:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M02_L38
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L182
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L34:
       add       ecx,30
       mov       [rdx-2],cx
M02_L35:
       xor       ecx,ecx
       mov       [rsp+138],rcx
       mov       eax,1
M02_L36:
       xor       ecx,ecx
       mov       [rsp+138],rcx
M02_L37:
       test      eax,eax
       je        near ptr M02_L109
       mov       r8d,[rsp+230]
       add       r8d,[rsp+140]
       mov       [rsp+230],r8d
       jmp       near ptr M02_L30
M02_L38:
       mov       rcx,rdi
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L39:
       cmp       dword ptr [rsp+1E0],1
       jne       short M02_L41
       jmp       near ptr M02_L81
M02_L40:
       mov       r8,rax
       mov       [rsp+0C8],rdx
       mov       [rsp+0D0],r9d
       mov       [rsp+0D8],rcx
       xor       ecx,ecx
       mov       [rsp+0E0],ecx
       mov       rcx,[rsp+220]
       mov       [rsp+20],rcx
       mov       rcx,r8
       lea       rdx,[rsp+0C8]
       lea       r9,[rsp+0D8]
       lea       r8,[rsp+140]
       mov       r11,7FFC93E705C0
       call      qword ptr [r11]
       jmp       near ptr M02_L37
M02_L41:
       mov       eax,[rsp+1E0]
       mov       [rsp+1CC],eax
       test      eax,eax
       jl        near ptr M02_L92
       mov       r8,[rsp+1D0]
       mov       [rsp+98],r8
       test      r8,r8
       je        near ptr M02_L180
       cmp       [r8+8],eax
       je        near ptr M02_L12
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+90],rax
       lea       rcx,[rax+10]
       mov       rdx,[rsp+98]
       lea       r10,[rdx+10]
       mov       edx,[rdx+8]
       mov       r9d,[rsp+1CC]
       cmp       r9d,edx
       jg        near ptr M02_L54
       mov       edx,r9d
M02_L42:
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L10
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L11
M02_L43:
       xor       ecx,ecx
       mov       [rsp+220],rcx
       mov       rcx,221F0C01DF8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC94189EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+228],rax
       test      rax,rax
       je        near ptr M02_L147
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L44:
       mov       [rsp+238],rdx
       mov       [rsp+240],eax
       xor       ecx,ecx
       mov       [rsp+230],ecx
       mov       byte ptr [rsp+234],0
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rax,[rsp+238]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L148
       mov       rcx,2218020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+230]
       inc       ecx
       mov       [rsp+230],ecx
M02_L45:
       cmp       r15,r13
       jne       near ptr M02_L150
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L52
M02_L46:
       cmp       byte ptr [rsp+234],0
       jne       near ptr M02_L151
M02_L47:
       test      r15,r15
       je        near ptr M02_L151
       mov       r8d,[rsp+230]
       cmp       r8d,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L151
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+230]
       add       edx,[r15+8]
       mov       [rsp+230],edx
M02_L48:
       mov       edx,[rsp+230]
       cmp       edx,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L152
       mov       rdx,221802087F4
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+230]
       add       edx,3
       mov       [rsp+230],edx
M02_L49:
       mov       [rsp+1B0],r12
       cmp       byte ptr [rsp+234],0
       jne       near ptr M02_L111
       mov       rdx,[rsp+1B0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC93FB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L87
       mov       rdx,[rsp+1B0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC93FB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L51
M02_L50:
       mov       rdx,[rsp+1B0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC93FB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rdx,[rsp+238]
       mov       r9d,ecx
       lea       rdx,[rdx+r9*2]
       mov       r9d,[rsp+240]
       sub       r9d,ecx
       xor       ecx,ecx
       mov       r8,offset MT_System.UInt16
       cmp       [rax],r8
       jne       near ptr M02_L66
       add       rax,8
       movzx     ecx,word ptr [rax]
       mov       r8d,ecx
       mov       r11d,ecx
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rax,7FFCC8F187A0
       add       r8,[rax+r11*8]
       sar       r8,20
       cmp       r8d,r9d
       jg        near ptr M02_L154
       mov       [rsp+1A0],r8d
       mov       [rsp+198],rdx
       movsxd    r9,r8d
       lea       r14,[rdx+r9*2]
       cmp       ecx,0A
       jb        near ptr M02_L69
       jmp       near ptr M02_L82
M02_L51:
       mov       rdx,[rsp+1B0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC93FB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+220]
       mov       r11,7FFC93E705A8
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L86
M02_L52:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L149
       mov       rcx,r15
       call      qword ptr [7FFC94065050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L53:
       mov       [rsp+1B8],r15
       mov       [rsp+1C0],eax
       lea       rcx,[rsp+1B8]
       call      qword ptr [7FFC941A6B50]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L46
M02_L54:
       jmp       near ptr M02_L42
M02_L55:
       xor       r8d,r8d
       mov       [rsp+148],r8
       lea       r8,[rsp+150]
       cmp       qword ptr [rsp+148],0
       jne       short M02_L56
       mov       r8,[r8]
       mov       [rsp+148],r8
       lea       r8,[rsp+148]
       cmp       qword ptr [rsp+148],0
       je        near ptr M02_L112
M02_L56:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L113
       cmp       [rcx],cl
M02_L57:
       mov       r15,rcx
M02_L58:
       test      r15,r15
       je        near ptr M02_L30
       mov       r8d,[rsp+230]
       cmp       r8d,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L114
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+230]
       add       ecx,[r15+8]
       mov       [rsp+230],ecx
       jmp       near ptr M02_L30
M02_L59:
       xor       ecx,ecx
       mov       [rsp+1A8],rcx
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rax,[rsp+238]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+240]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L158
       mov       rcx,2218020878C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+230]
       inc       ecx
       mov       [rsp+230],ecx
M02_L60:
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rax,[rsp+238]
       mov       [rsp+0D8],rax
       mov       [rsp+0E0],ecx
       lea       rcx,[rsp+0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rsp+228]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+220],ymm0
       vmovdqu   xmmword ptr [rsp+238],xmm0
       test      r13,r13
       je        near ptr M02_L63
       mov       rcx,221F0C01DF8
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFC93EF5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L159
M02_L61:
       xor       eax,eax
       mov       dword ptr [rsp+190],1
       cmp       [rcx+8],r14d
       jbe       short M02_L62
       mov       dword ptr [rsp+194],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r13+8],edx
       jne       near ptr M02_L93
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+78],r10
       mov       r9,[r10]
       mov       [rsp+70],r9
       mov       rcx,r10
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+78]
       mov       [rdx+8],ecx
       mov       rax,[rsp+70]
       test      rax,rax
       mov       [rsp+70],rax
       mov       eax,[rsp+194]
       jne       near ptr M02_L160
M02_L62:
       mov       rcx,221F0C005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L174
M02_L63:
       mov       rdx,r12
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M02_L65
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L64:
       mov       rdx,[rsp+150]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC93FB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+220]
       mov       r11,7FFC93E705B8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L58
M02_L65:
       mov       rcx,rdi
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L66:
       mov       r8,rax
       mov       [rsp+0C8],rdx
       mov       [rsp+0D0],r9d
       mov       [rsp+0D8],rcx
       xor       ecx,ecx
       mov       [rsp+0E0],ecx
       mov       rcx,[rsp+220]
       mov       [rsp+20],rcx
       mov       rcx,r8
       lea       rdx,[rsp+0C8]
       lea       r9,[rsp+0D8]
       lea       r8,[rsp+1A0]
       mov       r11,7FFC93E705B0
       call      qword ptr [r11]
M02_L67:
       test      eax,eax
       je        near ptr M02_L153
       mov       r8d,[rsp+230]
       add       r8d,[rsp+1A0]
       mov       [rsp+230],r8d
       jmp       near ptr M02_L59
M02_L68:
       xor       ecx,ecx
       mov       [rsp+198],rcx
       jmp       short M02_L67
M02_L69:
       add       ecx,30
       mov       [r14-2],cx
M02_L70:
       xor       ecx,ecx
       mov       [rsp+198],rcx
       mov       eax,1
       jmp       short M02_L68
M02_L71:
       mov       rdx,22180203C30
       cmp       r8,rdx
       jne       near ptr M02_L139
       cmp       r15,r13
       jne       near ptr M02_L77
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L76
M02_L72:
       mov       rax,offset MT_System.Boolean
       cmp       [r12],rax
       jne       near ptr M02_L78
       add       r12,8
       cmp       byte ptr [r12],0
       je        near ptr M02_L136
       mov       r14,22180208A08
M02_L73:
       cmp       [r14],r14b
       call      qword ptr [7FFC940F4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M02_L79
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC940CCFF8]; System.Globalization.CultureInfo.get_TextInfo()
M02_L74:
       cmp       [rax],al
       test      r14,r14
       je        near ptr M02_L95
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC943C5F80]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L137
       cmp       dword ptr [r15+8],0
       je        near ptr M02_L137
       test      r14,r14
       je        near ptr M02_L138
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L138
       mov       ecx,[r15+8]
       mov       eax,[r14+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L96
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       r8,[r12+0C]
       mov       rcx,2218020878C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r12+0E]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r12+r8*2+0C]
       mov       rcx,22180208814
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r15+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r12+r8*2+0C]
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r12
M02_L75:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L80
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L182
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L76:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0F8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFC941A6AD8]
       vmovups   xmm0,[rsp+0F8]
       vmovups   [rsp+0E8],xmm0
       lea       rcx,[rsp+0E8]
       call      qword ptr [7FFC941A6B50]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L72
M02_L77:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
M02_L78:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M02_L73
M02_L79:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       near ptr M02_L74
M02_L80:
       mov       rcx,rdi
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L81:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       r8,[rsp+1D8]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rsp+0A0]
       jmp       near ptr M02_L13
M02_L82:
       cmp       ecx,64
       jb        short M02_L84
       mov       rdx,221F0C00290
       mov       rdx,[rdx]
M02_L83:
       add       r14,0FFFFFFFFFFFFFFFC
       mov       eax,ecx
       imul      rax,51EB851F
       shr       rax,25
       imul      r8d,eax,64
       mov       r10d,ecx
       sub       r10d,r8d
       mov       ecx,eax
       mov       rax,rdx
       shl       r10d,2
       mov       r8d,r10d
       mov       eax,[rax+r8+10]
       mov       [r14],eax
       cmp       ecx,64
       jae       short M02_L83
M02_L84:
       cmp       ecx,0A
       jb        near ptr M02_L69
       lea       rax,[r14-4]
       mov       rdx,221F0C00290
       mov       rdx,[rdx]
       shl       ecx,2
       mov       ecx,[rdx+rcx+10]
       mov       [rax],ecx
       jmp       near ptr M02_L70
M02_L85:
       mov       rdx,rcx
M02_L86:
       test      rdx,rdx
       je        near ptr M02_L59
       mov       r8d,[rsp+230]
       cmp       r8d,[rsp+240]
       ja        near ptr M02_L97
       mov       rcx,[rsp+238]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,r8d
       mov       r13d,[rdx+8]
       cmp       r13d,eax
       ja        near ptr M02_L157
       add       rdx,0C
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC94065B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rsp+230]
       mov       [rsp+230],r13d
       jmp       near ptr M02_L59
M02_L87:
       xor       r8d,r8d
       mov       [rsp+1A8],r8
       lea       r8,[rsp+1B0]
       cmp       qword ptr [rsp+1A8],0
       jne       short M02_L88
       mov       r8,[r8]
       mov       [rsp+1A8],r8
       lea       r8,[rsp+1A8]
       cmp       qword ptr [rsp+1A8],0
       je        near ptr M02_L155
M02_L88:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L156
       jmp       near ptr M02_L85
M02_L89:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,22180208780
       mov       r8,22180208798
       call      qword ptr [7FFC93FB6B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L90
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L90:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L91:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC944464A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC93FBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L92:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC9414ED48]
       int       3
M02_L93:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC9444CAE0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC93E64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC93FBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L94:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC9444CAE0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC93E64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC93FBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L95:
       mov       ecx,16EB
       mov       rdx,7FFC93E64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC941766E8]
       int       3
M02_L96:
       call      qword ptr [7FFC9414EF40]
       int       3
M02_L97:
       call      qword ptr [7FFC9414E9D0]
       int       3
M02_L98:
       mov       rcx,221F0C01E18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L99:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L06
M02_L100:
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+98]
       call      qword ptr [rdx+20]
       mov       rcx,221802021B8
       cmp       rax,rcx
       jne       near ptr M02_L15
M02_L101:
       mov       rcx,[rsp+0B8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L15
       mov       rcx,[rsp+0B8]
       mov       rdx,r12
       call      qword ptr [7FFC943C5EF0]
       mov       r13,rax
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,22180208780
       mov       r8,22180208808
       call      qword ptr [7FFC93FB6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L102
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L102:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L103:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L17
M02_L104:
       lea       rcx,[rsp+220]
       mov       rdx,22180208780
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L18
M02_L105:
       xor       eax,eax
       jmp       near ptr M02_L27
M02_L106:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+234],0
       je        near ptr M02_L20
M02_L107:
       lea       rcx,[rsp+220]
       mov       rdx,r15
       call      qword ptr [7FFC940D5848]
       jmp       near ptr M02_L21
M02_L108:
       lea       rcx,[rsp+220]
       mov       rdx,22180208808
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L22
M02_L109:
       lea       rcx,[rsp+220]
       call      qword ptr [7FFC940D5938]
       jmp       near ptr M02_L23
M02_L110:
       xor       ecx,ecx
       mov       [rsp+140],ecx
       xor       eax,eax
       jmp       near ptr M02_L36
M02_L111:
       lea       rcx,[rsp+220]
       mov       r8,[rsp+1B0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC9455D7D0]
       jmp       near ptr M02_L59
M02_L112:
       xor       r15d,r15d
       jmp       near ptr M02_L58
M02_L113:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L57
M02_L114:
       lea       rcx,[rsp+220]
       mov       rdx,r15
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L30
M02_L115:
       mov       rcx,r15
       call      qword ptr [7FFC9417D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L31
M02_L116:
       mov       rcx,[r15+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M02_L182
       mov       edx,r12d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+134],eax
       jne       short M02_L117
       mov       rcx,r15
       mov       edx,r12d
       call      qword ptr [7FFC9417D7E8]
       mov       r10,rax
M02_L117:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFC93EF5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC93EF5C38],0
       je        short M02_L119
       call      qword ptr [7FFC93FBDC98]
       mov       edx,eax
       mov       [rsp+118],edx
       jmp       short M02_L122
M02_L118:
       lea       rcx,[rsp+220]
       mov       r8,[rsp+150]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC9455D7D0]
       jmp       near ptr M02_L30
M02_L119:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+114],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+114]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L120
       call      qword ptr [7FFC94555D10]
       mov       edx,eax
       jmp       short M02_L121
M02_L120:
       mov       edx,ecx
       sar       edx,10
M02_L121:
       mov       [rsp+118],edx
M02_L122:
       mov       rcx,7FFC93EF5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+118]
       xor       edx,edx
       div       dword ptr [7FFC93EF5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L129
M02_L123:
       cmp       eax,[r8+8]
       jae       near ptr M02_L182
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+110],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+10C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L125
       test      r10d,r10d
       jne       short M02_L126
       xor       edx,edx
       mov       [rax+14],edx
M02_L124:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M02_L125:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+110]
       test      ecx,ecx
       je        short M02_L127
       mov       r8d,1
       jmp       short M02_L130
M02_L126:
       jmp       short M02_L124
M02_L127:
       mov       eax,[rsp+120]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M02_L128
       xor       r8d,r8d
M02_L128:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,r8d
M02_L129:
       mov       r8,[rsp+38]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L123
       xor       r8d,r8d
M02_L130:
       mov       eax,r8d
       mov       [rsp+130],eax
       mov       eax,[rsp+134]
       jmp       near ptr M02_L32
M02_L131:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+130]
       cmp       dword ptr [r14+8],0
       mov       [rsp+134],edx
       mov       [rsp+58],r8
       mov       [rsp+130],eax
       je        near ptr M02_L33
       cmp       [r14],r14b
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+12C],eax
       mov       edx,[r14+8]
       mov       [rsp+128],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+12C]
       mov       r9d,[rsp+128]
       mov       edx,3
       call      qword ptr [7FFC94067678]
       mov       eax,[rsp+134]
       test      [rsp+130],eax
       mov       [rsp+134],eax
       jne       near ptr M02_L33
       cmp       [r14],r14b
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[r14+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+124],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rsp+134]
       test      r15d,r15d
       jne       short M02_L132
       mov       r12,[rsp+50]
       mov       edx,[rsp+124]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L133
M02_L132:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+124]
       mov       r8d,ecx
       mov       ecx,r12d
       mov       r12,rdx
       mov       edx,r8d
M02_L133:
       mov       r8d,r14d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L134
       mov       eax,1
       jmp       short M02_L135
M02_L134:
       xor       eax,eax
M02_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r12
       call      qword ptr [7FFC9417E2B0]
       jmp       near ptr M02_L33
M02_L136:
       mov       r14,221802089E8
       jmp       near ptr M02_L73
M02_L137:
       mov       r8,r14
       mov       rcx,22180208780
       mov       rdx,22180208808
       call      qword ptr [7FFC93FB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L75
M02_L138:
       mov       rdx,r15
       mov       rcx,22180208780
       mov       r8,22180208808
       call      qword ptr [7FFC93FB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L75
M02_L139:
       lea       rcx,[rsp+220]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC940D56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rdx,[rsp+238]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L140
       mov       rcx,2218020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+230]
       inc       ecx
       mov       [rsp+230],ecx
       jmp       short M02_L141
M02_L140:
       lea       rcx,[rsp+220]
       mov       rdx,22180208780
       call      qword ptr [7FFC940D58F0]
M02_L141:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+220]
       call      qword ptr [7FFC940D5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rdx,[rsp+238]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L142
       mov       rcx,221802087F4
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+230]
       add       ecx,3
       mov       [rsp+230],ecx
       jmp       short M02_L143
M02_L142:
       lea       rcx,[rsp+220]
       mov       rdx,221802087E8
       call      qword ptr [7FFC940D58F0]
M02_L143:
       lea       rcx,[rsp+220]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC94247978]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+230]
       cmp       ecx,[rsp+240]
       ja        near ptr M02_L97
       mov       rdx,[rsp+238]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+240]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L144
       mov       rcx,2218020878C
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+230]
       inc       ecx
       mov       [rsp+230],ecx
       jmp       short M02_L145
M02_L144:
       lea       rcx,[rsp+220]
       mov       rdx,22180208780
       call      qword ptr [7FFC940D58F0]
M02_L145:
       lea       rcx,[rsp+220]
       call      qword ptr [7FFC940D5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L146
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M02_L182
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L28
M02_L146:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC9406E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L28
M02_L147:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L44
M02_L148:
       lea       rcx,[rsp+220]
       mov       rdx,22180208780
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L45
M02_L149:
       xor       eax,eax
       jmp       near ptr M02_L53
M02_L150:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+234],0
       je        near ptr M02_L47
M02_L151:
       lea       rcx,[rsp+220]
       mov       rdx,r15
       call      qword ptr [7FFC940D5848]
       jmp       near ptr M02_L48
M02_L152:
       lea       rcx,[rsp+220]
       mov       rdx,221802087E8
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L49
M02_L153:
       lea       rcx,[rsp+220]
       call      qword ptr [7FFC940D5938]
       jmp       near ptr M02_L50
M02_L154:
       xor       ecx,ecx
       mov       [rsp+1A0],ecx
       xor       eax,eax
       jmp       near ptr M02_L68
M02_L155:
       xor       edx,edx
       jmp       near ptr M02_L86
M02_L156:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L85
M02_L157:
       lea       rcx,[rsp+220]
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L59
M02_L158:
       lea       rcx,[rsp+220]
       mov       rdx,22180208780
       call      qword ptr [7FFC940D58F0]
       jmp       near ptr M02_L60
M02_L159:
       mov       rcx,r15
       call      qword ptr [7FFC9417D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L61
M02_L160:
       mov       rcx,[r15+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L182
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+194],eax
       jne       short M02_L161
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFC9417D7E8]
       mov       r10,rax
M02_L161:
       mov       r10,[r10+8]
       mov       [rsp+68],r10
       mov       rcx,7FFC93EF5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC93EF5C38],0
       je        short M02_L162
       call      qword ptr [7FFC93FBDC98]
       mov       edx,eax
       mov       [rsp+178],edx
       jmp       short M02_L165
M02_L162:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+174],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+174]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L163
       call      qword ptr [7FFC94555D10]
       mov       edx,eax
       jmp       short M02_L164
M02_L163:
       mov       edx,ecx
       sar       edx,10
M02_L164:
       mov       [rsp+178],edx
M02_L165:
       mov       rcx,7FFC93EF5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+178]
       xor       edx,edx
       div       dword ptr [7FFC93EF5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L172
M02_L166:
       cmp       eax,[r8+8]
       jae       near ptr M02_L182
       mov       [rsp+180],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+60],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+170],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+16C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L168
       test      r10d,r10d
       jne       short M02_L169
       xor       edx,edx
       mov       [rax+14],edx
M02_L167:
       movsxd    rdx,r10d
       mov       r8,[rsp+70]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+16C]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+170],1
M02_L168:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+170]
       test      ecx,ecx
       je        short M02_L170
       mov       r8d,1
       jmp       short M02_L173
M02_L169:
       jmp       short M02_L167
M02_L170:
       mov       eax,[rsp+180]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+68]
       cmp       [rcx+8],r8d
       jne       short M02_L171
       xor       r8d,r8d
M02_L171:
       mov       edx,[rsp+17C]
       inc       edx
       mov       eax,r8d
M02_L172:
       mov       r8,[rsp+68]
       mov       [rsp+17C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L166
       xor       r8d,r8d
M02_L173:
       mov       eax,r8d
       mov       [rsp+190],eax
       mov       eax,[rsp+194]
       jmp       near ptr M02_L62
M02_L174:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+190]
       cmp       dword ptr [r13+8],0
       mov       [rsp+194],edx
       mov       [rsp+88],r8
       mov       [rsp+190],eax
       je        near ptr M02_L63
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+18C],eax
       mov       edx,[r13+8]
       mov       [rsp+188],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+18C]
       mov       r9d,[rsp+188]
       mov       edx,3
       call      qword ptr [7FFC94067678]
       mov       eax,[rsp+194]
       test      [rsp+190],eax
       mov       [rsp+194],eax
       jne       near ptr M02_L63
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+88]
       mov       [rsp+80],rdx
       mov       [rsp+184],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rsp+194]
       test      r15d,r15d
       jne       short M02_L175
       mov       r14,[rsp+80]
       mov       edx,[rsp+184]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L176
M02_L175:
       mov       rdx,[rsp+80]
       mov       ecx,[rsp+184]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L176:
       mov       r8d,r13d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L177
       mov       eax,1
       jmp       short M02_L178
M02_L177:
       xor       eax,eax
M02_L178:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFC9417E2B0]
       jmp       near ptr M02_L63
M02_L179:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M02_L08
M02_L180:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+1D0],rax
       jmp       near ptr M02_L12
M02_L181:
       mov       rcx,r10
       mov       edx,1C
       mov       rax,[r10]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M02_L14
M02_L182:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 8559
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.NewtonsoftSingleProperty()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,20917C01E00
       mov       rsi,[rax]
       call      qword ptr [7FFC943B6A00]; Newtonsoft.Json.JsonSerializer.CreateDefault()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC943B4420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,8C34942D
       mov       r9d,74882AAF
       call      qword ptr [7FFC94515F68]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; Newtonsoft.Json.JsonSerializer.CreateDefault()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,20917C04E38
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC943B69B8]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbx,rbx
       jne       short M01_L03
M01_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC943B6A30]
       jmp       short M01_L01
; Total bytes of code 94
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,20917C00428
       mov       r13,[rcx]
       mov       rcx,20917C014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20900301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,20917C05028
       mov       rax,20917C05030
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC9438A878
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC9404D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC941D9938]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC943BEB50]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC93E50CE8
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ValueMapperBenchmarks.TextJsonSingleProperty()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rax,19C50001E00
       mov       rax,[rax]
       mov       [rsp+38],rax
       call      qword ptr [7FFC943A4F48]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L03
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,[rdi+0B8]
       mov       r8,19C00208758
       cmp       rdx,r8
       jne       short M00_L04
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFC943A6B38]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0C67BAFE7
       mov       r9d,7402D28A
       call      qword ptr [7FFC94445140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC943A5578]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L04:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,19C00208758
       mov       r8d,1
       call      qword ptr [7FFC943A4E28]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC93F843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 274
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,19C50004EF8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,19C50004EF8
       xor       edx,edx
       jmp       qword ptr [7FFC943A5620]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC943A55F0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M02_L12
M02_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M02_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,19C50001F10
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC94567BB0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M02_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M02_L02
M02_L01:
       mov       edx,2
M02_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M02_L13
       mov       rdi,19C00201C08
M02_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M02_L14
M02_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC943A68F8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M02_L08
       cmp       [rcx+8],r15d
       jb        short M02_L07
M02_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M02_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M02_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M02_L07
       mov       r12d,r15d
       jmp       short M02_L10
M02_L07:
       call      qword ptr [7FFC9411E9D0]
       int       3
M02_L08:
       test      r15d,r15d
       jne       short M02_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M02_L05
M02_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M02_L06
M02_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC943AD110]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M02_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M02_L00
M02_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC9455D1E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L13:
       mov       rcx,7FFC9437C390
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19C50004F38
       mov       rdi,[rcx]
       jmp       near ptr M02_L03
M02_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC94556748]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M02_L04
M02_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC9455CCF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC945568C8]
       mov       r14,r13
       jmp       near ptr M02_L04
M02_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M02_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L18
M02_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L19
M02_L18:
       mov       rax,[rcx]
       add       rax,10
M02_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M02_L20
       test      r10d,r10d
       jne       short M02_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M02_L23
M02_L20:
       cmp       [rcx+8],r10d
       jae       short M02_L22
M02_L21:
       call      qword ptr [7FFC9411E9D0]
       int       3
M02_L22:
       add       rcx,10
M02_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M02_L25
       cmp       rdx,300
       ja        short M02_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC94035BA8]
M02_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,19C50001F10
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC94567BB8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M04_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC943A4390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M04_L05
       call      qword ptr [7FFC943A7150]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC93F84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M04_L03
       jmp       near ptr M04_L09
M04_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L03:
       call      qword ptr [7FFC943A7360]
       test      eax,eax
       je        near ptr M04_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC94444450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC94444450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC94444480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC943A7228]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M04_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC94444318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC94444318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC94444318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC943A5578]
       jmp       short M04_L09
M04_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC94444390]
       jmp       short M04_L09
M04_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC93F84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M04_L07
M04_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M04_L08
M04_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M04_L08:
       cmp       dword ptr [rbp-34],0
       je        short M04_L09
       call      qword ptr [7FFC943AC180]
M04_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC943A5530]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M05_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC943A4DE0]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC94444360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       cmp       qword ptr [rbp-8],0
       je        short M05_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC943A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M05_L01
M05_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC943A5590]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M05_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M05_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC94244720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M05_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC943A4FF0]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC943AC768]
M05_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M06_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M06_L02
M06_L01:
       mov       rax,rdx
       ret
M06_L02:
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       jne       short M06_L00
M06_L03:
       lea       rax,[7FFCC997B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

